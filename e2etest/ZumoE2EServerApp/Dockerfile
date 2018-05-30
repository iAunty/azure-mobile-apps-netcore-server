FROM microsoft/aspnetcore:2.0-nanoserver-1709 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.0-nanoserver-1709 AS build
WORKDIR /src
COPY e2etest/ZumoE2EServerApp/ZumoE2EServerApp.csproj e2etest/ZumoE2EServerApp/
RUN dotnet restore e2etest/ZumoE2EServerApp/ZumoE2EServerApp.csproj
COPY . .
WORKDIR /src/e2etest/ZumoE2EServerApp
RUN dotnet build ZumoE2EServerApp.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish ZumoE2EServerApp.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "ZumoE2EServerApp.dll"]
