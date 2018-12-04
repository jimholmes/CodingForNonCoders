using System;

using L8.Payroll;

namespace L8.Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            HourlyWageComputer computer = new HourlyWageComputer();
            decimal wages = computer.ComputeWages(0, 10);

            if (wages==0)
            {
                Console.WriteLine("PASSED: 0 hours, 10 rate returned 0");
            } else {
                Console.WriteLine("Check failed. Wages was: " + wages);
            }

            wages = computer.ComputeWages(1, 10);

            if (wages==10)
            {
                Console.WriteLine("Passed: 1 hour, 10 rate returned 10");
                
            }else {
                Console.WriteLine("Check failed. Wages was: " + wages);
            }

        }
    }
}
