using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.AspNetCore.Azure.Mobile.Server.Tables.Tables
{
    /// <summary>
    /// Performs configuration customizations for <see cref="TableController{TData}"/> derived controllers.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class TableControllerConfigAttribute : MobileAppControllerAttribute, IControllerConfiguration
    {
        /// <inheritdoc />
        public override void Initialize(HttpControllerSettings controllerSettings, HttpControllerDescriptor controllerDescriptor)
        {
            if (controllerDescriptor == null)
            {
                throw new ArgumentNullException("controllerDescriptor");
            }

            base.Initialize(controllerSettings, controllerDescriptor);

            ITableControllerConfigProvider tableConfigurationProvider = controllerDescriptor.Configuration.GetTableControllerConfigProvider();
            tableConfigurationProvider.Configure(controllerSettings, controllerDescriptor);
        }
    }
}
