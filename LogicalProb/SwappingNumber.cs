using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    internal class SwapTwoNumber
    {
        public void swapping()
        {

            Console.WriteLine("Enter First number");
            float a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            float b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("a ={0},b={1}", a, b);
            float c = a;
            a = b;
            b = c;
            Console.WriteLine("After Swapping a ={0},b={1}", a, b);
        }
    }
}
