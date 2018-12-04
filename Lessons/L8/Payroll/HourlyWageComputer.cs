using System;

namespace L8.Payroll
{
    public class HourlyWageComputer
    {
        // HourlyWageComputer.ComputeWages
        // SalaryWageComputer.ComputeWages


        public decimal ComputeWages(int hours, int hourlyRate)
        {
            return hours * hourlyRate;
        }
    }
}