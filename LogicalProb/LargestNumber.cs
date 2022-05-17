using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    internal class LargestNum
    {
        public void Largestnumber()
        {

            Console.WriteLine("Enter Your first number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your second number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your third number");
            int num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 >= num2 && num1 >= num3)
            {
                Console.WriteLine("Largest number: " + num1);
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                Console.WriteLine("Largest number: " + num2);
            }
            else if (num3 >= num1 && num3 >= num2)
            {
                Console.WriteLine("Largest number: " + num3);
            }
        }
    }
}
