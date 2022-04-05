using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to RFP-131Batch");
            Console.WriteLine("1:CoinFlipPercentage\n2:LeapYear\n3:PowerOfTwo\n4:HarmonicNumber\n5:Factorization\n6:QuotientAndReminder\n7:Swap\n8:EvenOddNumber\n9:VowelConsoonant\n10:LargestNumber");
            int option = Convert.ToInt32(Console.ReadLine());//"1"
            switch (option)
            {
                case 1:
                    CoinFlipPercentage coinFlipPercentage = new CoinFlipPercentage();
                    coinFlipPercentage.CheckPercentage();
                    Console.WriteLine();
                    break;

                case 2:
                    Leap_Year leap_Year = new Leap_Year();
                    leap_Year.CheckLeapYear();
                    Console.WriteLine();
                    break;
                case 3:
                    Power_Of_Two powerOfTwo = new Power_Of_Two();
                    powerOfTwo.PowerOfTwo();
                    Console.WriteLine();
                    break;
                case 4:
                    Harmonic_Number harmonicNumber = new Harmonic_Number();
                    harmonicNumber.HarmonicNumber();
                    Console.WriteLine();
                    break;
                case 5:
                    Factorization factorization = new Factorization();
                    factorization.CalcFactorisation();
                    Console.WriteLine();
                    break;
                case 6:
                    Quotient_And_Remainder quotientAndRemainder = new Quotient_And_Remainder();
                    quotientAndRemainder.QuotientAndRemainder();
                    Console.WriteLine();
                    break;
                case 7:
                    SwapNumber swapNumber = new SwapNumber();   
                    swapNumber.SwapingOfNumbers();
                    Console.WriteLine();
                    break;
                case 8:
                    EvenOddNumbercs evenOddNumbercs = new EvenOddNumbercs();
                    evenOddNumbercs.EvenOdd();
                    Console.WriteLine();
                    break;
                case 9:
                    Vowel_Consoonant vowel_Consoonant = new Vowel_Consoonant();
                    vowel_Consoonant.VowelConsonant();
                    Console.WriteLine();
                    break;
                case 10:
                    LargestNumbercs largestNumbercs = new LargestNumbercs();
                    largestNumbercs.LargestNum();
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("Please choose number within range");
                    break;
            }
            Console.ReadLine();

        }
    }
}