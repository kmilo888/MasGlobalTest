namespace MasGlobalTest.DAL.Models
{
    public class EmployeeServiceModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string contractTypeName { get; set; }
        public int roleId { get; set; }
        public string roleName { get; set; }
        public string roleDescription { get; set; }
        public float hourlySalary { get; set; }
        public float monthlySalary { get; set; }

    }
}
