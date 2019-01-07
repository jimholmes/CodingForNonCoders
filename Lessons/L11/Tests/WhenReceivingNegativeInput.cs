using System;
using NUnit.Framework;

using L11.Payroll;

namespace L11.Tests
{
    public class WhenReceivingNegativeInput {
        [Test]
        public void ThenNegative1HoursAt10Rate_ReturnsErrorNegativeHours() {
            HourlyWageCalculator calculator = new HourlyWageCalculator();
            decimal actualWages = calculator.ComputeWages(-1, 10);
            Assert.AreEqual(HourlyWageCalculator.ERROR_NEGATIVE_HOURS_INPUT, actualWages);
        }

        [Test]
        public void Then1HourAtNegative1Rate_ReturnsErrorNegativeRate() {
            HourlyWageCalculator calculator = new HourlyWageCalculator();
            decimal actualWages = calculator.ComputeWages(1,-1);
            Assert.AreEqual(HourlyWageCalculator.ERROR_NEGATIVE_RATE_INPUT, actualWages);
        }
    }
    
}
