using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Enter & read weight
            Console.Write("Enter weight (kg): ");
            string input = Console.ReadLine();
            float weight = float.Parse(input);

            //Enter & read length
            Console.Write("Enter length (cm): ");
            string input2 = Console.ReadLine();
            float length = float.Parse(input2);

            //Enter & read weight
            Console.Write("Enter gender (male/female): ");
            string gender = Console.ReadLine();
            
            //Calculate square of height & BMI-value
            float sh1 = length / 100;
            float sh2 = sh1 * sh1;
            float BMI = length / sh2;

            // Calculate healthy weight range female
            float HW_F_min = 19 * sh2;
            float HW_F_max = 24 * sh2;

            // Calculate healthy weight range male
            float HW_M_min = 20 * sh2;
            float HW_M_max = 25 * sh2;
            
            //Reply if female
            if (gender == "female" )
            {
                Console.WriteLine("Normal bmi-values (min .. max): 19..24");
                Console.WriteLine("Healthy weight range: {0:00.0} .. {1:00.0}", HW_F_min, HW_F_max);
            }
            //Reply if male
            else
            {
                Console.WriteLine("Normal bmi-values (min .. max): 20..25");
                Console.WriteLine("Healthy weight range: {0:00.0} .. {1:00.0}", HW_M_min, HW_M_max);
            }

            //End program
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
