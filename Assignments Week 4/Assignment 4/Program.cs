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
            int n1 = 1;
            int n2 = 1;

            for (int i = 0; i < 20; i++)
            {
                //Create Fibonacci
                int nTmp = n1;
                n1 = n2;
                n2 = n2 + nTmp;

                //Show Fibonacci
                Console.Write(nTmp + ", ");
            }

            //End program
            Console.WriteLine("... Press any key to exit");
            Console.ReadKey();
        }
    }
}
