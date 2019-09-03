using MasGlobalTest.DAL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MasGlobalTest.DAL.Interfaces
{
    public interface IEmployeeService
    {
        Task<List<EmployeeServiceModel>> GetEmployees();
    }
}
