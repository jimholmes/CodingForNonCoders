using System;

namespace L5
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int loopCount = 0; loopCount < 10; loopCount++)
            {
                Console.WriteLine("loopCount: " + loopCount);
            }

            int doCount = 0;
            do
            {
                Console.WriteLine("Do Loop Count = " + doCount);
                doCount++;
            } while (doCount < 5);

            int whileCount = 0;
            while (whileCount < 5)
            {
                Console.WriteLine("While Loop Count = " + whileCount);
                whileCount++;           
            }
        }
    }
}
