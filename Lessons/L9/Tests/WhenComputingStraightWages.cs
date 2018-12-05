using NUnit.Framework;

using L9.Payroll;

namespace L9.Tests
{
    public class WhenComputingStraightWages
    {
        /*
            I've left two different approaches for handling the "Arrange"
            part of these tests -- one using a class-level variable
            for the wage calculator, and the other using test-level variables.

            This shows how you can use NUnit's SetUp to handle configuration,
            initialization, etc. within the fixture/class versus each individual
            test.

            Please listen closely to the discussion in L9 on some of the subtleties
            of why this may or may not be a good approach. Be thoughtful!
         */
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

        [TestCase(0, 10, 0)]
        [TestCase(1,10,10)]
        [TestCase(40,10,400)]
        public void CheckAllStraightTimeBoundaryValues(int hoursWorked, 
                                                        int hourlyRate, 
                                                        decimal expectWages) {
            HourlyWageCalculator calculator = new HourlyWageCalculator();
            decimal actualWages = calculator.ComputeWages(hoursWorked, hourlyRate);
            Assert.AreEqual(expectWages, actualWages, "TestCase Data: Hours Worked:" + hoursWorked +
                                                                      " Hourly Rate: " + hourlyRate +
                                                                      " Expected: " + expectWages);
        }

        
    }
}