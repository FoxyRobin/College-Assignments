using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read target number
            Console.Write("Enter target number: ");
            int target = int.Parse(Console.ReadLine());

            int count = 0;

            //Read number
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            //Start loop
            while (number != 0)
            {
                if (number == target)
                {
                    count ++;
                }

                //Read next number
                Console.Write("Enter number: ");
                number = int.Parse(Console.ReadLine());
            }

            //Display average positive numbers
            Console.WriteLine("Count of numbers equal to targer number: {0}", count);

            //End program
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
