using System;

namespace L9.Payroll
{
    public class HourlyWageCalculator
    {
        public decimal ComputeWages(int hoursWorked, int hourlyRate)
        {
            return hoursWorked * hourlyRate;
        }
    }
}