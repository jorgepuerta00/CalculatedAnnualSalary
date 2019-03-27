using System;

namespace MasGlobal.CalculatedAnnualSalary.BusinessLogic.Core
{
    public interface ICalculateAnnualSalaryStrategy
    {
        double CalculateAnnualSalary(double dbSalary);
    }
}
