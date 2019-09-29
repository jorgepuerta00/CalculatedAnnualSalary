using System.Collections.Generic;
using CalculatedAnnualSalary.BusinessLogic.Core;
using CalculatedAnnualSalary.DataAccess.Repository;
using CalculatedAnnualSalary.DTO.Model;

namespace CalculatedAnnualSalary.BusinessLogic.Bussiness
{
    public class InfoEmployee
    {

        IRepository repository;
        AnnualSalaryCalculator AnnualSalaryCalculator = new AnnualSalaryCalculator();

        public InfoEmployee(IRepository repositoryP)
        {
            repository = repositoryP;
        }

        public List<EmployeeDTO> GetEmployees(int? Id)
        {
            List<EmployeeDTO> dataEmployees = repository.GetEmployeeById(Id);
            foreach (EmployeeDTO dataEmployee in dataEmployees)
            {
                dataEmployee.AnnualSalary = AnnualSalaryCalculator.CalculateAnnualSalary(dataEmployee.ContractTypeName, dataEmployee.HourlySalary, dataEmployee.MonthlySalary);
            }
            return dataEmployees;
        }
    }
}
