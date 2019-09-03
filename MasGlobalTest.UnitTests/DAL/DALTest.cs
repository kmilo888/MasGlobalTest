using MasGlobalTest.DAL.Interfaces;
using MasGlobalTest.UnitTests.Configuration;
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
            var services = new ServiceCollection();
            _service = services.ConfigureDALServices();
        }

        [Fact]
        public async Task GetAllEmployeesFromService()
        {
            var tasks = await _service.GetEmployees();

            Assert.NotEmpty(tasks);
        }
    }
}
