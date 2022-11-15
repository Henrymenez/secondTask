using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secondTest
{
    internal class leapYear
    {
        public void CheckleapYear()
        {
            Console.Write("Show 20 leap years starting from? ");
            string check = Console.ReadLine();
            int year = Int32.Parse(check);
            int count = 0;
            while (count != 20)
            {
                if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
                {
                    Console.WriteLine(year + " is a leap year.");
                    count++;
                }
                year++;

            }
        }
    }
}
