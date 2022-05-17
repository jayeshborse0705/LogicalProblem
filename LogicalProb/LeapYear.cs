using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    internal class LeapYear
    {
        public void Leap()
        {
            Console.WriteLine("Enter Year : ");
            int Year = Convert.ToInt32(Console.ReadLine());
            if (Year < 1000 || Year > 9999)
            {
                Console.WriteLine("Please enter correct year");
            }
            else
            {
                if (((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0))
                {
                    Console.WriteLine("{0} is a Leap Year.", Year);
                }
                else
                {
                    Console.WriteLine("{0} is not a Leap Year.", Year);
                    Console.ReadLine();
                }
            }
        }
    }
}
