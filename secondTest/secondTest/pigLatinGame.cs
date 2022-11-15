using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secondTest
{
    internal class pigLatinGame
    {
        public void pigLatin()
        {
            string newWord = "";
            Console.Write("Please Enter Word to be converted: ");
            string phrase = Console.ReadLine();
            if (string.IsNullOrEmpty(phrase))
            {
                Console.Write("Please Enter Word to be converted: ");
                phrase = Console.ReadLine();
            }
            else
            {
                string[] words = phrase.Split(' ');
                foreach (string word in words)
                {
                    if (word.Length > 1)
                    {
                        string res = word.Remove(1);
                        string firstRemove = word.Remove(0, 1);
                        string pigLatin = firstRemove + res + "ay";
                        newWord = newWord + " " + pigLatin.ToLower();
                    }
                }
                Console.WriteLine(newWord);
            }
        }
    }


}
