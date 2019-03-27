using MasGlobal.CalculatedAnnualSalary.WebAppEmployees.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace MasGlobal.CalculatedAnnualSalary.WebAppEmployees.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Employee(string Id)
        {
            IEnumerable<Employee> employees = GetEmployeeInfo(Id);
            return View(employees);
        }

        public IEnumerable<Employee> GetEmployeeInfo(string Id)
        {
            IEnumerable<Employee> employees = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:54638/api/");

                var responseTask = client.GetAsync("employees/" + Id);
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<Employee>>();
                    readTask.Wait();
                    employees = readTask.Result;

                    if (employees.Count() == 0)
                    {
                        ModelState.AddModelError(string.Empty, "No data found.");
                    }
                }
                else
                {
                    employees = Enumerable.Empty<Employee>();
                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }

            return employees;
        }
    }
}