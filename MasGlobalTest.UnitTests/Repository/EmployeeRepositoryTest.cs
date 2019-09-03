using MasGlobalTest.BLL.Interfaces;
using MasGlobalTest.UnitTests.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MasGlobalTest.UnitTests.Repository
{
    public class EmployeeRepositoryTest
    {
        private IEmployeeRepository _employeeRepository;

        public EmployeeRepositoryTest()
        {
            var services = new ServiceCollection();
            _employeeRepository = services.ConfigureEmployeeRepositoryServices();
        }

        [Fact]
        public async Task GetAllEmployees()
        {
            var tasks = await _employeeRepository.GetAllEmployees();

            Assert.NotEmpty(tasks);

        }
    }
}
