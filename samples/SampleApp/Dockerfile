FROM microsoft/aspnetcore:2.0-nanoserver-1709 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.0-nanoserver-1709 AS build
WORKDIR /src
COPY samples/SampleApp/SampleApp.csproj samples/SampleApp/
RUN dotnet restore samples/SampleApp/SampleApp.csproj
COPY . .
WORKDIR /src/samples/SampleApp
RUN dotnet build SampleApp.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish SampleApp.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "SampleApp.dll"]
