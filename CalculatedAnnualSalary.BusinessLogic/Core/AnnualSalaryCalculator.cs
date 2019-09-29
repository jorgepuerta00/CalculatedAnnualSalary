using System;

namespace CalculatedAnnualSalary.BusinessLogic.Core
{
    public class AnnualSalaryCalculator
    {
        private AnnualSalaryCalculationStrategyFactory AnnualSalaryCalculationStrategyFactory = new AnnualSalaryCalculationStrategyFactory();
        public double CalculateAnnualSalary(string ContractType, double dbHourlySalaryValue, double dbMonthlySalaryValue)
        {
            ICalculateAnnualSalaryStrategy CalculateAnnualSalaryStrategy = AnnualSalaryCalculationStrategyFactory.GetAnnualSalaryCalculationStrategy(ContractType);
            return CalculateAnnualSalaryStrategy.CalculateAnnualSalary(dbHourlySalaryValue, dbMonthlySalaryValue);
        }        
    }
}
