using System;

namespace L9.Payroll
{
    public class HourlyWageCalculator
    {
        private const int MAX_STRAIGHT_TIME_HOURS = 40;
        private const decimal OVERTIME_MULTIPLIER = 1.5m;

        public decimal ComputeWages(int hoursWorked, int hourlyRate)
        {
            decimal wages=0;

            if (hoursWorked > MAX_STRAIGHT_TIME_HOURS)
            {
                int otHours = hoursWorked - MAX_STRAIGHT_TIME_HOURS;
                decimal otWages = otHours * hourlyRate * OVERTIME_MULTIPLIER;
                wages = otWages + MAX_STRAIGHT_TIME_HOURS * hourlyRate;
            } else {
                wages = hoursWorked * hourlyRate;
            }
            
            return wages;
        }
    }
}