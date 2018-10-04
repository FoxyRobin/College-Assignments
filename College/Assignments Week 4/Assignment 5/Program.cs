using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = 0;

            do
            {
                Console.Write("Enter a year: ");
                year = int.Parse(Console.ReadLine());

                if (year < 0)
                {
                    Console.WriteLine("Year must be positive!");
                    continue;
                }

                if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
                {
                    Console.WriteLine("{0} is a leap year.", year);
                }
                else
                {
                    Console.WriteLine("{0} is not a leap year.", year);
                }
            } while (year != 0);

        }
    }
}
