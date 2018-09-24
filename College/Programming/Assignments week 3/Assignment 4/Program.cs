using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
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

            //Read third number
            Console.Write("Enter third number: ");
            string input3 = Console.ReadLine();
            float nr3 = float.Parse(input3);

            //Calculate total, average and product
            float sum = nr1 + nr2 + nr3;
            float average = sum / 3;
            float product = nr1 * nr2 * nr3;

            //Display total, average and product
            Console.WriteLine("sum = {0}", sum);
            Console.WriteLine("average = {0:0.00}", average);
            Console.WriteLine("product = {0}", product);

            //Display highest
            if (nr1 > nr2 && nr1 > nr3)
            {
                Console.WriteLine("highest = {0}", nr1);
            }
            else
            {
                if (nr2 > nr1 && nr2 > nr3)
                {
                    Console.WriteLine("highest = {0}", nr2);
                }
                else
                {
                    Console.WriteLine("highest = {0}", nr3);
                }
            }

            //Display lowest
            if (nr1 < nr2 && nr1 < nr3)
            {
                Console.WriteLine("lowest = {0}", nr1);
            }
            else
            {
                if (nr2 < nr1 && nr2 < nr3)
                {
                    Console.WriteLine("lowest = {0}", nr2);
                }
                else
                {
                    Console.WriteLine("lowest = {0}", nr3);
                }
            }

            //End program
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
