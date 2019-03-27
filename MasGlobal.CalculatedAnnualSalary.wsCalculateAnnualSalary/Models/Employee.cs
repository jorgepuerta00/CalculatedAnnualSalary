using MasGlobal.CalculatedAnnualSalary.DTO.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MasGlobal.CalculatedAnnualSalary.wsCalculateAnnualSalary.Models
{
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public class Employee
    {
        [JsonProperty(PropertyName = "Id")]
        public int Id { get; set; }
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "ContractTypeName")]
        public string ContractTypeName { get; set; }
        [JsonProperty(PropertyName = "RoleId")]
        public int RoleId { get; set; }
        [JsonProperty(PropertyName = "RoleName")]
        public string RoleName { get; set; }
        [JsonProperty(PropertyName = "RoleDescription")]
        public string RoleDescription { get; set; }
        [JsonProperty(PropertyName = "HourlySalary")]
        public double HourlySalary { get; set; }
        [JsonProperty(PropertyName = "MonthlySalary")]
        public double MonthlySalary { get; set; }
        [JsonProperty(PropertyName = "AnnualSalary")]
        public double AnnualSalary { get; set; }

        public Employee() { }

        public Employee(EmployeeDTO employee)
        {
            Id = employee.Id;
            Name = employee.Name;
            ContractTypeName = employee.ContractTypeName;
            RoleId = employee.RoleId;
            RoleName = employee.RoleName;
            RoleDescription = employee.RoleDescription;
            HourlySalary = employee.HourlySalary;
            MonthlySalary = employee.MonthlySalary;
        }
    }
}