using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using CalculatedAnnualSalary.Common;
using CalculatedAnnualSalary.WebAppEmployees.Models;
using Microsoft.AspNetCore.Mvc;

namespace CalculatedAnnualSalary.WebAppEmployees.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Employee(int? id)
        {
            IEnumerable<Employee> employees = GetEmployeeInfo(new Employee(Id: id));
            return View(employees);
        }

        public IEnumerable<Employee> GetEmployeeInfo(Employee emp)
        {
            JsonEngine objEngine = new JsonEngine("https://wscalculatedannualsalary.azurewebsites.net/api/Employee/GetEmployees/", 60000);

            List<Employee> objEmployeeList = objEngine.ExecutePostOperation<List<Employee>>(emp);

            if (objEmployeeList.Count() == 0)
            {
                ModelState.AddModelError(string.Empty, "No data found.");
            }

            return objEmployeeList;
        }
    }
}