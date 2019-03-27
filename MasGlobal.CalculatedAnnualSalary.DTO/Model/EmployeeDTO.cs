using System;
using System.Runtime.Serialization;

namespace MasGlobal.CalculatedAnnualSalary.DTO.Model
{
    [DataContract()]
    public partial class EmployeeDTO
    {
        [DataMember()]
        public int Id { get; set; }

        [DataMember()]
        public string Name { get; set; }

        [DataMember()]
        public string ContractTypeName { get; set; }

        [DataMember()]
        public int RoleId { get; set; }

        [DataMember()]
        public string RoleName { get; set; }

        [DataMember()]
        public string RoleDescription { get; set; }

        [DataMember()]
        public double HourlySalary { get; set; }

        [DataMember()]
        public double MonthlySalary { get; set; }
    }
}
