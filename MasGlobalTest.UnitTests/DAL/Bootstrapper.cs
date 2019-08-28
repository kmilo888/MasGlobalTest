using MasGlobalTest.Common.Settings;
using MasGlobalTest.DAL.Implementations;
using MasGlobalTest.DAL.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MasGlobalTest.UnitTests.DAL
{
    public static class Bootstrapper
    {
        public static void UseServices(this IServiceCollection services, IConfigurationRoot configuration)
        {
            services.AddHttpClient<IEmployeeService, EmployeeService>();
            AppSettings appSettings = new AppSettings();
            configuration.Bind("AppSettings", appSettings);
            services.AddSingleton(appSettings);
        }
    }
}
