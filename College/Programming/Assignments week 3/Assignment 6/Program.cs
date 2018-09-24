using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Enter & read score
            Console.Write("Enter score: ");
            string input = Console.ReadLine();
            int score = int.Parse(input);

            //90-100 points = A, passed
            if (score >= 90)
            {
                Console.WriteLine("Grade: A" + Environment.NewLine + "Course passed");
            }
            else
            {
                //80-89 points = B, passed
                if (score >= 80)
                {
                    Console.WriteLine("Grade: B" + Environment.NewLine + "Course passed");
                }
                else
                {
                    //70-79 points = C, passed
                    if (score >= 70)
                    {
                        Console.WriteLine("Grade: C" + Environment.NewLine + "Course passed");
                    }
                    else
                    {
                        //60-69 points = D, not passed
                        if (score >= 60)
                        {
                            Console.WriteLine("Grade: D" + Environment.NewLine + "Course not passed");
                        }
                        
                        //<60 points = F, not passed
                        else
                        {
                            Console.WriteLine("Grade: F" + Environment.NewLine + "Course not passed");
                            
                        }
                    }
                }
            }
           
            //End program
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
