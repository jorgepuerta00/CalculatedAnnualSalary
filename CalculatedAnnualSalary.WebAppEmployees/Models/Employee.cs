using System.ComponentModel;

namespace CalculatedAnnualSalary.WebAppEmployees.Models
{
    public class Employee
    {
        [DisplayName("Employee Id")]
        public int? Id { get; set; }
        [DisplayName("Full Name")]
        public string Name { get; set; }
        [DisplayName("Contract Type Name")]
        public string ContractTypeName { get; set; }
        [DisplayName("Role Id")]
        public int RoleId { get; set; }
        [DisplayName("Role Name")]
        public string RoleName { get; set; }
        [DisplayName("Role Description")]
        public string RoleDescription { get; set; }
        [DisplayName("Hourly Salary")]
        public double HourlySalary { get; set; }
        [DisplayName("Monthly Salary")]
        public double MonthlySalary { get; set; }
        [DisplayName("Annual Salary")]
        public double AnnualSalary { get; set; }

        public Employee()
        {

        }

        public Employee(int? Id)
        {
            this.Id = Id;
        }
    }
}