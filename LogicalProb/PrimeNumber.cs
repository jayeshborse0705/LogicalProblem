using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    internal class PrimeFactors
    {
        public void PrimeFactor()
        {
            Console.WriteLine("Enter your number: ");
            int Number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The prime factors are: ");
            for (int b = 2; b <= Number; b++)
            {
                if (Number % b == 0)
                {
                    int IsPrime = 1;
                    for (int i = 2; i <= b / 2; i++)
                    {
                        if (b % i == 0)
                        {
                            IsPrime = 0;

                            break;
                        }
                        if (IsPrime == 0)
                            break;
                    }

                    if (IsPrime == 1)
                    {
                        Console.Write(" "+b);
                    }
                }

            }
        }
    }
}
