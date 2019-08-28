using MasGlobalTest.DAL.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;
using Xunit;

namespace MasGlobalTest.UnitTests.DAL
{
    public class DALTest
    {
        private IEmployeeService _service;

        public DALTest()
        {
            var config = new ConfigurationBuilder()
                .AddJsonFile(@"DAL\appsettings.json")
                .Build();

            var services = new ServiceCollection();
            services.UseServices(config);

            var serviceProvider = services.BuildServiceProvider();

            _service = serviceProvider.GetRequiredService<IEmployeeService>();
        }

        [Fact]
        public async Task GetAllEmployees()
        {
            var tasks = await _service.GetEmployees();

            Assert.NotEmpty(tasks);
        }
    }
}
