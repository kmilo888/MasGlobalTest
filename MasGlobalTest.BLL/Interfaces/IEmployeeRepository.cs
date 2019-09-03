using System.Collections.Generic;
using System.Threading.Tasks;

namespace MasGlobalTest.BLL.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<List<IEmployee>> GetAllEmployees();
        Task<IEmployee> GetEmployeeById(int id);
    }
}
