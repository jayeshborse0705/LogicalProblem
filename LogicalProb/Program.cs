using System;

namespace BasicCorePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Please enter number as per options");
            Console.WriteLine("1: For Flip a coin and find % of Head and Tail");
            Console.WriteLine("2: For checking leap year");
            Console.WriteLine("3: For finding power of 2");

            int check = Convert.ToInt32(Console.ReadLine());
            switch (check)
            {

                case 1:
                    FlipCoin FlippingCoin = new FlipCoin();
                    FlippingCoin.Flip_Coin();
                    break;
                case 2:
                    LeapYear Leap_Year = new LeapYear();
                    Leap_Year.Leap();
                    break;
                case 3:
                    PowerOfTwo PowerTwo = new PowerOfTwo();
                    PowerTwo.PowerTwo();
                    break;
                default:
                    Console.WriteLine("Please SELECT correct number ! ");
                    break;

            }


        }
    }
}
