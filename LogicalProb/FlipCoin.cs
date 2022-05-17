using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    internal class FlipCoin
    {
        public int Head = 0;
        public int Tail = 0;
        public void Flip_Coin()
        {
            Console.WriteLine("Enter How many times do you want to flip a coin");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number <= 0)
            {
                Console.WriteLine("Please enter a correct positive number");
            }
            else
            {
                for (int i = 0; i < number; i++)
                {
                    Random RandomNumber = new Random();
                    float Random_Number = (float)RandomNumber.NextDouble();
                    if (Random_Number < 0.5)
                    {
                        Head++;
                        {
                            Tail++;
                        }
                        // Console.WriteLine(+Random_Number);
                    }

                    else
                        Console.WriteLine("Number of Heads occurred: " + Head);
                    Console.WriteLine("Number of Tails occurred: " + Tail);
                    Console.WriteLine("% Head occured:" + (float)(Head * 100 / number));
                    Console.WriteLine("% Tail occured:" + (float)(Tail * 100 / number));
                }
            }
        }
    }
}
