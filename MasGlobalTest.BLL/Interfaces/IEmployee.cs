namespace MasGlobalTest.BLL.Interfaces
{
    public interface IEmployee
    {
        int Id { get; set; }
        string Name { get; set; }
        string ContractTypeName { get; set; }
        int RoleId { get; set; }
        string RoleName { get; set; }
        string RoleDescription { get; set; }
        float AnnualSalary { get; }
    }
}
