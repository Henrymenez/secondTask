using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secondTest
{
    internal class guessingGame
    {
        public void guessNmuber()
        {
            string secretNumber = "15";
            string guess;
            int guessCount = 1;
            int guessLimit = 3;
            bool outOfGuesses = false;
            List<string> list = new List<string>();
            Console.Write("Guess Secret Number: ");
            guess = Console.ReadLine();
            try
            {
                while (guess != secretNumber && !outOfGuesses)
                {
                    list.Add(guess);
                    if (guessCount < guessLimit)
                    {
                        if (Int32.Parse(guess) > Int32.Parse(secretNumber))
                        {
                                 foreach(string s in list)
                        {
                            if(guess == s){
                               //do nothing
                            }else{
                                guessCount++;
                            }
                        
                        }
                            Console.WriteLine("Too High");
                            Console.Write("Enter a Number: ");
                            guess = Console.ReadLine();
                        
                            
                        }
                        else
                        {
                                  foreach(string s in list)
                        {
                             if(guess == s){
                               //do nothing
                            }else{
                                guessCount++;
                            }
                        }
                            Console.WriteLine("Too Low");
                            Console.Write("Enter a Number: ");
                            guess = Console.ReadLine();
                        
                        }
                    }
                    else
                    {
                       
                        outOfGuesses = true;
                    }
                }
                if (outOfGuesses)
                {
                    Console.WriteLine($"You Lost, you had {guessLimit} number of trials");
                    Console.ReadLine();
                }
                else
                {
                     
                    Console.WriteLine("You Won");
                    Console.ReadLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }

        }
    }
}
