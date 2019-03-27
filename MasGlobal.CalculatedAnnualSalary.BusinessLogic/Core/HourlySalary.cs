using System;
using System.Collections.Generic;
using System.Text;

namespace MasGlobal.CalculatedAnnualSalary.BusinessLogic.Core
{
    public class HourlySalary : ICalculateAnnualSalaryStrategy
    {
        public double CalculateAnnualSalary(double dbSalaryValue)
        {
            return 120 * dbSalaryValue * 12;
        }
    }
}
