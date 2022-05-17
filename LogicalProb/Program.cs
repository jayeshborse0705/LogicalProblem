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
            int check = Convert.ToInt32(Console.ReadLine());
            switch (check)
            {

                case 1:
                    FlipCoin FlippingCoin = new FlipCoin();
                    FlippingCoin.Flip_Coin();
                    break;
                
                default:
                    Console.WriteLine("Please SELECT correct number ! ");
                    break;

            }


        }
    }
}

