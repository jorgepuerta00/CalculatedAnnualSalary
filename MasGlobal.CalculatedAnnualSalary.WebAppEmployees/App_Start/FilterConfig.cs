using System.Web;
using System.Web.Mvc;

namespace MasGlobal.CalculatedAnnualSalary.WebAppEmployees
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
