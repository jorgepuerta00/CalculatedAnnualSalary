using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatedAnnualSalary.BusinessLogic.Core;
using CalculatedAnnualSalary.BusinessLogic.Bussiness;
using CalculatedAnnualSalary.DTO.Model;
using System.Collections.Generic;
using CalculatedAnnualSalary.DataAccess.Repository;

namespace CalculatedAnnualSalary.UnitTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            AnnualSalaryCalculator AnnualSalaryCalculator = new AnnualSalaryCalculator();
            var result = AnnualSalaryCalculator.CalculateAnnualSalary("HourlySalaryEmployee", 1, 0);

            Assert.AreEqual(1440, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            AnnualSalaryCalculator AnnualSalaryCalculator = new AnnualSalaryCalculator();
            var result = AnnualSalaryCalculator.CalculateAnnualSalary("HourlySalaryEmployee", 60000, 0);

            Assert.AreEqual(86400000, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            AnnualSalaryCalculator AnnualSalaryCalculator = new AnnualSalaryCalculator();
            var result = AnnualSalaryCalculator.CalculateAnnualSalary("MonthlySalaryEmployee", 0, 1);

            Assert.AreEqual(12, result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            AnnualSalaryCalculator AnnualSalaryCalculator = new AnnualSalaryCalculator();
            var result = AnnualSalaryCalculator.CalculateAnnualSalary("MonthlySalaryEmployee", 0, 80000);

            Assert.AreEqual(960000, result);
        }

        public void TestMethod5()
        {
            IRepository _operationRepository = new Repository();

            InfoEmployee obj = new InfoEmployee(_operationRepository);
            EmployeeDTO emp = obj.GetEmployees(1).ToList().FirstOrDefault();

            AnnualSalaryCalculator AnnualSalaryCalculator = new AnnualSalaryCalculator();
            var result = AnnualSalaryCalculator.CalculateAnnualSalary(emp.ContractTypeName, emp.HourlySalary, emp.MonthlySalary);

            Assert.AreEqual(86400000, result);
        }

        [TestMethod]
        public void TestMethod6()
        {
            IRepository _operationRepository = new Repository();

            InfoEmployee obj = new InfoEmployee(_operationRepository);
            EmployeeDTO emp = obj.GetEmployees(2).ToList().FirstOrDefault();

            AnnualSalaryCalculator AnnualSalaryCalculator = new AnnualSalaryCalculator();
            var result = AnnualSalaryCalculator.CalculateAnnualSalary(emp.ContractTypeName, emp.HourlySalary, emp.MonthlySalary);

            Assert.AreEqual(960000, result);
        }
    }
}
