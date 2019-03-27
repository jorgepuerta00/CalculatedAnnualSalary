using System;
using System.Collections.Generic;
using System.Text;

namespace MasGlobal.CalculatedAnnualSalary.BusinessLogic.Core
{
    public class Context
    {
        private ICalculateAnnualSalaryStrategy strategy;

        public Context(ICalculateAnnualSalaryStrategy strategy)
        {
            this.strategy = strategy;
        }

        public double CalculateAnnualSalaryStrategy(double dbValue)
        {
            return strategy.CalculateAnnualSalary(dbValue);
        }
    }
}
