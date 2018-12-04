using NUnit.Framework;

using L9.Payroll;

namespace L9.Tests
{
    public class WhenComputingStraightWages
    {

        HourlyWageCalculator calculatorClassVariable;

        [SetUp]
        public void RunOnceBeforeEachTest() {
            calculatorClassVariable  = new HourlyWageCalculator();
        }

        [Test]
        public void ThenZeroHoursAtTenRate_ReturnsZero()
        {
            decimal wages = calculatorClassVariable.ComputeWages(0, 10);
            Assert.AreEqual(0, wages);
        }

        [Test]
        public void ThenOneHourAtTenRate_ReturnsTen()
        {
            HourlyWageCalculator calculator = new HourlyWageCalculator();
            decimal wages = calculator.ComputeWages(1, 10);
            Assert.AreEqual(10, wages);
        }

        [Test]
        public void ThenFortyHoursAtTenRate_Returns400()
        {
            HourlyWageCalculator calculator = new HourlyWageCalculator();
            decimal wages = calculator.ComputeWages(40, 10);
            Assert.AreEqual(400, wages);
        }
    }
}