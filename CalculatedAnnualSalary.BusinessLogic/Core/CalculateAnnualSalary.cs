namespace CalculatedAnnualSalary.BusinessLogic.Core
{
    public class HourlySalary : ICalculateAnnualSalaryStrategy
    {
        public double CalculateAnnualSalary(double dbHourlySalaryValue, double dbMonthlySalaryValue)
        {
            return 120 * dbHourlySalaryValue * 12;
        }
    }

    public class MonthlySalary : ICalculateAnnualSalaryStrategy
    {
        public double CalculateAnnualSalary(double dbHourlySalaryValue, double dbMonthlySalaryValue)
        {
            return dbMonthlySalaryValue * 12;
        }
    }
}
