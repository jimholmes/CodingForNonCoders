using System;
using NUnit.Framework;

using L13.Payroll;

namespace L13.Tests
{
    public class WhenWorkingWithRates{

        [Test]
        public void Then10HoursAtMaxRate_ReturnsProperValue() {
            HourlyWageCalculator calculator = new HourlyWageCalculator();
            decimal actualWages = calculator.ComputeWages(10, HourlyWageCalculator.MAX_HOURLY_RATE);
            decimal expectedWages = HourlyWageCalculator.MAX_HOURLY_RATE * 10;
            Assert.AreEqual(expectedWages, actualWages);
        }

        [Test]
        public void Then10HoursAt1Rate_Returns10(){
            HourlyWageCalculator calculator = new HourlyWageCalculator();
            decimal actualWages = calculator.ComputeWages(10, 1);
            Assert.AreEqual(10, actualWages);
        }
    }
    
}
