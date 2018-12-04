using System;

namespace L10.Payroll
{
    public class HourlyWageCalculator
    {
        public decimal ComputeWages(int hoursWorked, int hourlyRate)
        {
            if (hoursWorked > 40)
            {
                int otHours = hoursWorked - 40;
                decimal otWages = otHours * hourlyRate * 1.5m;
                decimal wages = otWages + (40 * hourlyRate);
                return wages;
            } else {
                return hoursWorked * hourlyRate;
            }
        }
    }
}