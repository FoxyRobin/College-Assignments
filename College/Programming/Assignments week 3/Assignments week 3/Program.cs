using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_week_3
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

            //Display highest & lowest number - nr1>nr2
            if (nr1 > nr2)
            {
                Console.WriteLine(@"Highest value is: {0}" + Environment.NewLine + "Lowest value is: {1}", nr1, nr2);

            }

            //Display highest & lowest number - nr2>nr1
            else
            {
                Console.WriteLine(@"Highest value is: {0}" + Environment.NewLine + "Lowest value is: {1}", nr2, nr1);

            }
            
            //End program
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
