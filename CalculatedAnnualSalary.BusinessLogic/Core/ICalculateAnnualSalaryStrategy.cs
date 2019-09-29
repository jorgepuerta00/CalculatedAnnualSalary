namespace CalculatedAnnualSalary.BusinessLogic.Core
{
    public interface ICalculateAnnualSalaryStrategy
    {
        double CalculateAnnualSalary(double dbHourlySalaryValue, double dbMonthlySalaryValue);
    }
}
