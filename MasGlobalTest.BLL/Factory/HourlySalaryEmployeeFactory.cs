using MasGlobalTest.BLL.Entities;
using MasGlobalTest.BLL.Interfaces;
using MasGlobalTest.DAL.Models;

namespace MasGlobalTest.BLL.Factory
{
    public class HourlySalaryEmployeeFactory : EmployeeFactory
    {
        public override IEmployee Create(EmployeeServiceModel employeeServiceModel) =>
            new HourlySalaryEmployee()
            {
                Id = employeeServiceModel.id,
                Name = employeeServiceModel.name,
                ContractTypeName = employeeServiceModel.contractTypeName,
                RoleId = employeeServiceModel.roleId,
                RoleName = employeeServiceModel.roleName,
                RoleDescription = employeeServiceModel.roleDescription,
                HourlySalary = employeeServiceModel.hourlySalary
            };
    }
}
