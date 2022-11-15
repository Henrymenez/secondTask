using System;

namespace secondTest
{
    internal class Program
    {

       
        static void Main(string[] args)
        {
              Console.WriteLine("**LEAP YEAR COUNT**");
            leapYear lpy = new leapYear();
            lpy.CheckleapYear();

            Console.WriteLine("**Pig Latin Game**");
             pigLatinGame pl = new pigLatinGame();
             pl.pigLatin();

            
            Console.WriteLine("**Guess A Number**");
            guessingGame gg = new guessingGame();
            gg.guessNmuber();
            Console.WriteLine();
        }
    }
}