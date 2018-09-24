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
            //Read first number
            Console.Write("Enter first number: ");
            string input1 = Console.ReadLine();
            float nr1 = float.Parse(input1);

            //Read second number
            Console.Write("Enter second number: ");
            string input2 = Console.ReadLine();
            float nr2 = float.Parse(input2);

            //Calculate multiples
            float multiple1 = nr1 / nr2;
            float multiple2 = nr2 / nr1;

            //Display whether multiple or not
            if (multiple1 % 1 == 0)
            {
                Console.WriteLine("Number 1 is multiple of number 2");
            }
            else
            {
                if (multiple2 % 1 == 0)
                {
                    Console.WriteLine("Number 2 is multiple of number 1");
                }
                else
                {
                    Console.WriteLine("Numbers are no multiples");
                }
            }

            //End program
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
