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

            //Read number
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            List<int> values = new List<int>();

            int count = 0;

            //Start loop
            while (number != 0)
            {
                values.Add(number);

                //Read next number
                Console.Write("Enter a number: ");
                number = int.Parse(Console.ReadLine());

            }
                for (int i = 4; i < values.Count; i += 5) 
                {
                    count += values[i];
                }
                

            //Display average positive numbers
            Console.WriteLine("Sum of 5th, 10th, 15th... number is: {0}", count);

            //End program
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
