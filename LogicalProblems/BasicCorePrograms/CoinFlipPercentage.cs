using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class CoinFlipPercentage
    {
        public int HeadCount = 0;
        public int TailCount = 0;
        public int HeadPercentage = 0;
        public int TailPercentage = 0;
        Random random = new Random();

        public void CheckPercentage()
        {
            Console.WriteLine("Enter the number of times you want to flip the coin");
            int CoinFlip = Convert.ToInt32(Console.ReadLine());

            //Using For Loop For Number Of Times Coin Flip
            for (int i = 0; i < CoinFlip; i++)
            {
                double ChecFlip = random.Next(0, 2);
                if (ChecFlip < 0.5)
                {
                    Console.WriteLine("This is Head");
                    HeadCount++;
                }
                else
                {
                    Console.WriteLine("This is Tail");
                    TailCount++;

                }

                //Calculation of percentage
                HeadPercentage = HeadCount * (100 / CoinFlip);
                TailCount = TailCount * (100 / CoinFlip);
                Console.WriteLine("Percentage of Head:" + HeadPercentage);
                Console.WriteLine("Percentage of Tail:" + TailPercentage);
                Console.ReadLine();
            }
        }
    }
}
