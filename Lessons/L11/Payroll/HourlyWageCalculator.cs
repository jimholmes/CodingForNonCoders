using System;

namespace L11.Payroll
{
    public class HourlyWageCalculator
    {
        private const int MAX_STRAIGHT_TIME_HOURS = 40;
        private const decimal OVERTIME_MULTIPLIER = 1.5m;
        private const int MAX_HOURS = 80;
        public const int MAX_HOURLY_RATE = 500;
        public const decimal ERROR_NEGATIVE_HOURS_INPUT = -1;
        public const int ERROR_NEGATIVE_RATE_INPUT = -2;


        public decimal ComputeWages(int hoursWorked, int hourlyRate)
        {
            if (hoursWorked > MAX_HOURS)
            {
                throw new System.ArgumentException("Over MAX_HOURS. hoursWorked: " +
                                                    hoursWorked);
            }

            if (hourlyRate > MAX_HOURLY_RATE)
            {
                throw new System.ArgumentException("Over MAX_HOURLY_RATE. hourlyRate: " +
                                                    hourlyRate);                
            }

            if (hoursWorked < 0)
            {
                return ERROR_NEGATIVE_HOURS_INPUT;
            }

            if (hourlyRate < 0)
            {
                return ERROR_NEGATIVE_RATE_INPUT;
            }

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