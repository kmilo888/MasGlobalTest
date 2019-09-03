using MasGlobalTest.BLL.Factory;
using MasGlobalTest.BLL.Interfaces;
using MasGlobalTest.Common.Constants;
using MasGlobalTest.DAL.Interfaces;
using MasGlobalTest.DAL.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasGlobalTest.BLL.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private IEmployeeService _service;
        public EmployeeRepository(IEmployeeService service)
        {
            _service = service;
        }

        public async Task<List<IEmployee>> GetAllEmployees()
        {
            var employeesFromService = await _service.GetEmployees();
            List<IEmployee> allEmployees = new List<IEmployee>();
            foreach (var employeeFromService in employeesFromService)
            {
                var employee = GetEmployeeFromServiceModel(employeeFromService);
                if (employee != null)
                {
                    allEmployees.Add(employee);
                }
            }
            return allEmployees;
        }

        public async Task<IEmployee> GetEmployeeById(int id)
        {
            var employeesFromService = await _service.GetEmployees();
            var employeeFromService = employeesFromService.Single(e => e.id == id);
            var employee = GetEmployeeFromServiceModel(employeeFromService);
            return employee;
        }

        private static IEmployee GetEmployeeFromServiceModel(EmployeeServiceModel employeeFromService)
        {
            switch (employeeFromService.contractTypeName)
            {
                case ContractType.HourlySalaryEmployee:
                    var hourlySalaryEmployeeFactory = new HourlySalaryEmployeeFactory();
                    var hourlySalaryEmployee = hourlySalaryEmployeeFactory.Create(employeeFromService);
                    return hourlySalaryEmployee;
                case ContractType.MonthlySalaryEmployee:
                    var monthlySalaryEmployeeFactory = new MonthlySalaryEmployeeFactory();
                    var monthlySalaryEmployee = monthlySalaryEmployeeFactory.Create(employeeFromService);
                    return monthlySalaryEmployee;
                default:
                    return null;
            }
        }
    }
}
