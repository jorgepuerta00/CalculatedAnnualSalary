using System;
using System.Collections.Generic;
using System.Text;

namespace MasGlobal.CalculatedAnnualSalary.BusinessLogic.Core
{
    public class MonthlySalary : ICalculateAnnualSalaryStrategy
    {
        public double CalculateAnnualSalary(double dbSalaryValue)
        {
            return dbSalaryValue * 12;
        }
    }
}
