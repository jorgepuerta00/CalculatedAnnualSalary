using MasGlobal.CalculatedAnnualSalary.DTO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace MasGlobal.CalculatedAnnualSalary.DataAccess.Model
{
    public class InfoEmployee
    {
        public EmployeeDTO[] GetEmployees()
        {
            using (WebClient wc = new WebClient())
            {
                var json = wc.DownloadString("http://masglobaltestapi.azurewebsites.net/api/Employees");

                JavaScriptSerializer js = new JavaScriptSerializer();
                EmployeeDTO[] employees = js.Deserialize<EmployeeDTO[]>(json);

                return employees;
            }
        }
    }
}
