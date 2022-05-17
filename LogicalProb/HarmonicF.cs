using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    internal class HarmonicF
    {
        int i;
        public void HarmonicFunction()
        {

            Console.Write("Enter the number of terms : ");
            int Harmonic = Convert.ToInt32(Console.ReadLine());
            if (Harmonic == 0)
            {
                Console.WriteLine("Harmonic can not be zero");
            }
            else
            {
                Console.Write("Harmonics are: ");
                for (i = 1; i <= Harmonic; i++)
                {
                    Console.Write("1/{0} + ", i);
                }

            }
        }
    }
}
