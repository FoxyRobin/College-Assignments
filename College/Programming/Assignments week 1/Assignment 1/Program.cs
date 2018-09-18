using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Program
    {
        const double VAT_RATE = 0.21;

        static void Main(string[] args)
        {
            string input;
            double price;
            Console.WriteLine("Enter a price: ");
            input = Console.ReadLine();
            price = double.Parse(input);

            double VAT = price * VAT_RATE;
            double total = price + VAT;

            Console.WriteLine("Price: {0}, VAT: {1}, Total: {2}", price, VAT, total);

            Console.WriteLine(" ");

            Console.WriteLine("Enter a key to exit...");
            Console.ReadKey();
        }
    }
}