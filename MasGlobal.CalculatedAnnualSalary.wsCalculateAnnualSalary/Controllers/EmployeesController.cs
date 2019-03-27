using MasGlobal.CalculatedAnnualSalary.BusinessLogic.Core;
using MasGlobal.CalculatedAnnualSalary.DTO.Model;
using MasGlobal.CalculatedAnnualSalary.wsCalculateAnnualSalary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace MasGlobal.CalculatedAnnualSalary.wsCalculateAnnualSalary.Controllers
{
    public class EmployeesController : ApiController
    {
        EmployeeDTO[] dataEmployees = new DataAccess.Model.InfoEmployee().GetEmployees();

        // GET: api/employees
        [ResponseType(typeof(IEnumerable<Employee>))]
        public IEnumerable<Employee> Get()
        {
            List<Employee> employees = new List<Employee>();

            foreach (EmployeeDTO employee in dataEmployees)
            {
                Employee emp = new Employee(employee);
                emp.AnnualSalary = CalculateAnnualSalary(emp);
                employees.Add(emp);
            }

            return employees;
        }
        // GET: api/employees/1
        [ResponseType(typeof(IEnumerable<Employee>))]
        public IEnumerable<Employee> Get(int id)
        {
            List<Employee> employees = new List<Employee>();
            EmployeeDTO objEmployeeDto = dataEmployees.FirstOrDefault((p) => p.Id == id);

            if (objEmployeeDto == null)
            {
                return employees;
            }

            Employee employee = new Employee(objEmployeeDto);
            employee.AnnualSalary = CalculateAnnualSalary(employee);
            employees.Add(employee);

            return employees;
        }

        public double CalculateAnnualSalary(Employee employee)
        {
            Context context = null;
            double result = 0;

            switch (employee.ContractTypeName)
            {
                case "HourlySalaryEmployee":
                    context = new Context(new HourlySalary());
                    result = context.CalculateAnnualSalaryStrategy(employee.HourlySalary);
                    return result;

                case "MonthlySalaryEmployee":
                    context = new Context(new MonthlySalary());
                    result = context.CalculateAnnualSalaryStrategy(employee.MonthlySalary);
                    return result;
            }

            return result;
        }
    }
}
