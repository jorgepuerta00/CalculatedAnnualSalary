namespace CalculatedAnnualSalary.BusinessLogic.Core
{
    public class AnnualSalaryCalculationStrategyFactory
    {
        private ICalculateAnnualSalaryStrategy HourlySalaryCalculationStrategy = new HourlySalary();
        private ICalculateAnnualSalaryStrategy MonthlySalaryCalculationStrategy = new MonthlySalary();
        private ICalculateAnnualSalaryStrategy NoAnnualSalaryCalculationStrategy = new NoAnnualSalaryCalculation();

        public ICalculateAnnualSalaryStrategy GetAnnualSalaryCalculationStrategy(string ContractType)
        {
            switch (ContractType)
            {
                case "HourlySalaryEmployee": return HourlySalaryCalculationStrategy;
                case "MonthlySalaryEmployee": return MonthlySalaryCalculationStrategy;
                default: return NoAnnualSalaryCalculationStrategy;
            }

        }
    }
}