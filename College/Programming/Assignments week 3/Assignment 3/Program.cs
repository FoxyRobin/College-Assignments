using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read first number
            Console.Write("Enter first number: ");
            string input1 = Console.ReadLine();
            int nr1 = int.Parse(input1);

            //Read second number
            Console.Write("Enter second number: ");
            string input2 = Console.ReadLine();
            int nr2 = int.Parse(input2);

            //Read third number
            Console.Write("Enter third number: ");
            string input3 = Console.ReadLine();
            int nr3 = int.Parse(input3);

            //Display reply
            if (nr1 > nr3 && nr2 > nr3)
            {
                Console.WriteLine("The third number is the smallest of the three");
            }
            else
            {
                Console.WriteLine("The third number is not the smallest of the three");
            }

            //End program
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
