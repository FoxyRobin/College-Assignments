using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read number
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            int count = 0;
            int amount = 0;

            //Start loop
            while (number != 0)
            {
                if (number > 0)
                {
                    count += number;
                    amount++;
                }

                //Read next number
                Console.Write("Enter a number: ");
                number = int.Parse(Console.ReadLine());
            }

            //Display average positive numbers
            Console.WriteLine("Average of all positive numbers is: {0:0.00}", (double)count / amount);

            //End program
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
