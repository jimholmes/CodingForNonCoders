using System;
using NUnit.Framework;

using L11.Payroll;

namespace L11.Tests
{
    public class WhenRequiringSupervisorReview {

        [Test]
        public void Then81HoursAt10Rate_RaisesException_OLDSCHOOL() {
            HourlyWageCalculator calculator = new HourlyWageCalculator();
            
            try
            {
                calculator.ComputeWages(81, 10);   
            }
            catch (System.ArgumentException)
            {
                Assert.Pass();
            }
            Assert.Fail("System.ArgumentException not caught.");
        }

        [Test]
        public void Then81HoursAt10Rate_RaisesException() {
            HourlyWageCalculator calculator = new HourlyWageCalculator();

            Assert.Throws<System.ArgumentException>( () => calculator.ComputeWages(81, 10) );
        }

        [Test]
        public void Then10HoursAt501Rate_RaisesException() {
            HourlyWageCalculator calculator = new HourlyWageCalculator();

            Assert.Throws<System.ArgumentException>( () => calculator.ComputeWages(10, 501) );
        }
    }
    
}
