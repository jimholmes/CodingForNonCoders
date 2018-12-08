using NUnit.Framework;

using L11.Payroll;

namespace L11.Tests
{
    public class WhenComputingOvertimeWages{

        [Test]
        public void Then41HoursAt10Rate_Returns415() {
            HourlyWageCalculator calculator = new HourlyWageCalculator();
            decimal actualWages = calculator.ComputeWages(41, 10);
            Assert.AreEqual(415, actualWages);
        }

        [Test]
        public void Then80HoursAt10Rate_Returns1000() {
            HourlyWageCalculator calculator = new HourlyWageCalculator();
            decimal actualWages = calculator.ComputeWages(80, 10);
            Assert.AreEqual(1000, actualWages);
        }
    }
    
}