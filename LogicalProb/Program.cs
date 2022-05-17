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
            Console.WriteLine("4: For geting harmonic seies numbers");
            Console.WriteLine("5: For geting prime factor of a number");
            Console.WriteLine("6: For geting Qoutient and Remainder");

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
                case 4:
                    HarmonicF Harmoni_F = new HarmonicF();
                    Harmoni_F.HarmonicFunction();
                    break;
                case 5:
                    PrimeFactors PrimeFac = new PrimeFactors();
                    PrimeFac.PrimeFactor();
                    break;
                case 6:
                    QoutientRem Qoutient_Remainder = new QoutientRem();
                    Qoutient_Remainder.QoutientRemainder();
                    break;
                default:
                    Console.WriteLine("Please SELECT correct number ! ");
                    break;

            }


        }
    }
}