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
            //Read number
            Console.Write("Enter a number (1..4): ");
            string input = Console.ReadLine();
            int number = int.Parse(input);

            //Display reaction: 1=clubs, 2=diamonds, 3=hearts, 4=spades, >5=incorrect
            switch (number)
            {
                case 1:
                    Console.WriteLine("clubs");
                    break;
                case 2:
                    Console.WriteLine("diamonds");
                    break;
                case 3:
                    Console.WriteLine("hearts");
                    break;
                case 4:
                    Console.WriteLine("spades");
                    break;
                default:
                    Console.WriteLine("Incorrect number!");
                    break;
            }

            //End program
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
