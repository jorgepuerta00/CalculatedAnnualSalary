using System.Linq;
using System.Collections.Generic;
using CalculatedAnnualSalary.DTO.Model;
using CalculatedAnnualSalary.Common;

namespace CalculatedAnnualSalary.DataAccess.Repository
{
    public class Repository : IRepository
    {
        public List<EmployeeDTO> GetEmployeeById(int? Id)
        {
            JsonEngine objEngine = new JsonEngine("http://masglobaltestapi.azurewebsites.net/api/Employees", 60000);
            List<EmployeeDTO> objEmployeeList = objEngine.ExecuteGetOperation<List<EmployeeDTO>>();
            return objEmployeeList.Where(employee => Id == null || employee.Id == Id).ToList();
        }        
    }
}
