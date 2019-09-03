using System;
using MasGlobalTest.BLL.Interfaces;
using MasGlobalTest.BLL.Repositories;
using MasGlobalTest.Common.Settings;
using MasGlobalTest.DAL.Implementations;
using MasGlobalTest.DAL.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MasGlobalTest.UnitTests.Configuration
{
    public static class Bootstrapper
    {
        public static IEmployeeService ConfigureDALServices(this IServiceCollection services)
        {
            var configuration = new ConfigurationBuilder()
                .AddJsonFile(@"Configuration\appsettings.json")
                .Build();

            services.AddHttpClient<IEmployeeService, EmployeeService>();
            AppSettings appSettings = new AppSettings();
            configuration.Bind("AppSettings", appSettings);
            services.AddSingleton(appSettings);

            var serviceProvider = services.BuildServiceProvider();
            return serviceProvider.GetRequiredService<IEmployeeService>();

        }

        public static IEmployeeRepository ConfigureEmployeeRepositoryServices(this IServiceCollection services)
        {
            services.AddSingleton<IEmployeeService, EmployeeService>((ies) =>
            {
                var DALServices = new ServiceCollection();
                return (EmployeeService)DALServices.ConfigureDALServices();
            });

            services.AddTransient<IEmployeeRepository, EmployeeRepository>();

            var serviceProvider = services.BuildServiceProvider();

            return serviceProvider.GetRequiredService<IEmployeeRepository>();


        }
    }
}
