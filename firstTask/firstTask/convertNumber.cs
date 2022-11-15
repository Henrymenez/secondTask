using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstTask
{
    internal class convertNumber
    {

        string[] one = {"", "one ", "two ", "three ", "four ",
                "five ", "six ", "seven ", "eight ",
                    "nine ", "ten ", "eleven ", "twelve ",
                    "thirteen ", "fourteen ", "fifteen ",
                    "sixteen ", "seventeen ", "eighteen ",
                    "nineteen " };

        string[] ten = {"", "", "twenty ", "thirty ", "forty ",
                "fifty ", "sixty ", "seventy ", "eighty ",
                            "ninety " };

        public string numToWords(int n,string s)
        {
            try
            {
 
                string str = "";
                if (n > 19)
                {
                    str += ten[Convert.ToInt32(n / 10)] + one[n % 10];
                }
                else
                {
                    str += one[n];
                }

                // if n is non-zero
                if (n != 0)
                {
                    str += s;
                }
               return str;
            }catch(Exception ex)
            {
                return ex.Message;
            }
            
        }

        public string convertNumberToWords(int n)
        {

            string output = "";

    
		output += this.numToWords(Convert.ToInt32(n / 1000000000),
        "billion, ");
		
		output += this.numToWords(Convert.ToInt32(n / 1000000),
        "million, ");

		output += this.numToWords(Convert.ToInt32((n / 100000) % 100),
        "hundred and ");

	
		output += this.numToWords(Convert.ToInt32((n / 1000) % 100),
        "thousand ");

	
		output += this.numToWords(Convert.ToInt32((n / 100) % 10),
        "hundred ");

            if (n > 100 && n % 100 > 0)
            {
			output += "and ";
            }

		output += this.numToWords(Convert.ToInt32(n % 100), "");

            return output;
        }


    }
}
