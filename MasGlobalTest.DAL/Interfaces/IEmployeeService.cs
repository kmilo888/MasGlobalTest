using MasGlobalTest.DAL.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MasGlobalTest.DAL.Interfaces
{
    public interface IEmployeeService
    {
        Task<List<Employee>> GetEmployees();
    }
}
