using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            double startingPrice, finalPrice;

            Console.WriteLine("Please state the price of the computer:");
            startingPrice = double.Parse(Console.ReadLine());
            finalPrice = startingPrice + startingPrice / 100 * 17;
            Console.WriteLine("The final price with VAT is: " + finalPrice);
            Console.ReadLine();
        }
    }
}
