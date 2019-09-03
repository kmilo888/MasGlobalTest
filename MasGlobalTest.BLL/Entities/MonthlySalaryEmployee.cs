using MasGlobalTest.BLL.Interfaces;

namespace MasGlobalTest.BLL.Entities
{
    public class MonthlySalaryEmployee : IEmployee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ContractTypeName { get; set; }
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public string RoleDescription { get; set; }
        public float MonthlySalary { get; set; }
        public float AnnualSalary => MonthlySalary * 12;
    }
}
