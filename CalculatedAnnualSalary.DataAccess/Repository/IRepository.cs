using System.Collections.Generic;
using CalculatedAnnualSalary.DTO.Model;

namespace CalculatedAnnualSalary.DataAccess.Repository
{
    public interface IRepository
    {
        List<EmployeeDTO> GetEmployeeById(int? Id);
    }
}
