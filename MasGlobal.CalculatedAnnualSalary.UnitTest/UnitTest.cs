using System;
using MasGlobal.CalculatedAnnualSalary.BusinessLogic.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasGlobal.CalculatedAnnualSalary.UnitTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var context = new Context(new HourlySalary());
            var result = context.CalculateAnnualSalaryStrategy(1);
            Assert.AreEqual(1440, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var context = new Context(new HourlySalary());
            var result = context.CalculateAnnualSalaryStrategy(60000);
            Assert.AreEqual(86400000, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var context = new Context(new MonthlySalary());
            var result = context.CalculateAnnualSalaryStrategy(1);
            Assert.AreEqual(12, result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            var context = new Context(new MonthlySalary());
            var result = context.CalculateAnnualSalaryStrategy(80000);
            Assert.AreEqual(960000, result);
        }
    }
}
