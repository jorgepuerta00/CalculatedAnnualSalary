using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalculatedAnnualSalary.BusinessLogic.Bussiness;
using CalculatedAnnualSalary.DataAccess.Repository;
using CalculatedAnnualSalary.DTO.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalculatedAnnualSalary.wsAnnualSalary.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IRepository _operationRepository;

        public EmployeeController(IRepository operationRepository)
        {
            this._operationRepository = operationRepository;
        }

        // POST: api/Employee
        [Route("GetEmployees")]
        [HttpPost]
        public List<EmployeeDTO> GetEmployees([FromBody] EmployeeDTO emp)
        {
            InfoEmployee obj = new InfoEmployee(this._operationRepository);
            return obj.GetEmployees(emp.Id);
        }

        // GET: api/Employee
        [Route("GetEmployeesById")]
        [HttpGet]
        public List<EmployeeDTO> GetEmployeesById(string id)
        {
            InfoEmployee obj = new InfoEmployee(this._operationRepository);
            return obj.GetEmployees(int.Parse(id));
        }

        // GET: api/Employee/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Employee
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Employee/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
