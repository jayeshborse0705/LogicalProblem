using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    internal class EvenOdd
    {
        public void CheckEvenOdd()
        {
            Console.WriteLine("Enter Your number");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("The number {0} is even number", num);
            }
            else
            {
                Console.WriteLine("The number {0} is odd number", num);
            }
        }
    }
}
