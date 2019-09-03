using MasGlobalTest.BLL.Interfaces;
using MasGlobalTest.DAL.Models;

namespace MasGlobalTest.BLL.Factory
{
    public abstract class EmployeeFactory
    {
        public abstract IEmployee Create(EmployeeServiceModel employeeServiceModel);
    }
}
