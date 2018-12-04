using NUnit.Framework;

namespace Tests
{
    public class PayrollTests
    {

        [Test]
        public void OneHourAtTenRate_ReturnsTen()
        {
            HourlyCalculator calc = new HourlyCalculator();
            decimal wages = calc.ComputeWages(1, 10);

            Assert.AreEqual(10, wages);
        }
    }
}