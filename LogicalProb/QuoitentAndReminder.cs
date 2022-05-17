using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    internal class QoutientRem
    {
        public void QoutientRemainder()
        {
            Console.WriteLine("Enter Divisor");
            float Divisor = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter Divident");
            float Divident = Convert.ToInt64(Console.ReadLine());
            int Qoutient = (int)(Divisor / Divident);
            int Remainder = (int)(Divisor % Divident);
            Console.WriteLine("Qoutient: " + Qoutient);
            Console.WriteLine("Remainder: " + Remainder);
        }
    }
}