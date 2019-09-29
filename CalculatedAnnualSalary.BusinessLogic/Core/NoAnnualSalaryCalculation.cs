namespace CalculatedAnnualSalary.BusinessLogic.Core
{
    public class NoAnnualSalaryCalculation : ICalculateAnnualSalaryStrategy
    {
        public double CalculateAnnualSalary(double dbHourlySalaryValue, double dbMonthlySalaryValue)
        {
            return 0;
        }
    }
}
