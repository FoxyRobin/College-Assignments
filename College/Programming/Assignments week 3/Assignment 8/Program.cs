using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Enter & read working hours
            Console.Write("Enter number of working hours: ");
            string input1 = Console.ReadLine();
            int hours = int.Parse(input1);

            //Enter & read working years
            Console.Write("Enter number of years: ");
            string input2 = Console.ReadLine();
            int years = int.Parse(input2);

            //Enter & read working failures
            Console.Write("Enter number of working failures: ");
            string input3 = Console.ReadLine();
            int failures = int.Parse(input3);

            //10.000 hours or more = replace
            if (hours >= 10000)
            {
                Console.WriteLine("Machine needs to be replaced.");
            }
            //7 years or more = replace
            else if (years >=7)
            {
                Console.WriteLine("Machine needs to be replaced.");
            }
            //25 or more failures per year = replace
            else if (failures > 25)
            {
                Console.WriteLine("Machine needs to be replaced.");
            }
            //If none of above apply; don't replace
            else
            {
                Console.WriteLine("Machine does not need to be replaced.");
            }

            //End program
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
