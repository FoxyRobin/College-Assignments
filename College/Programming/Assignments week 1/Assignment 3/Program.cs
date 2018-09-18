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
            Console.WriteLine("Enter a number of seconds: ");
            int seconds = int.Parse(Console.ReadLine());

            //convert seconds to hours, minutes and leftover seconds
            TimeSpan timespan = TimeSpan.FromSeconds(seconds);
            int hour = timespan.Hours;
            int min = timespan.Minutes;
            int sec = timespan.Seconds;

            Console.WriteLine("{0}:{1}:{2}", hour, min, sec);
            Console.WriteLine("Enter a key to exit...");
            Console.ReadKey();
        }
    }
}
