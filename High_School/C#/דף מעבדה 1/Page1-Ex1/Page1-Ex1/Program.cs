using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page1_Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            double f ,c;

            Console.WriteLine("Please write the temperature in Fahrenheit:");
            f = double.Parse(Console.ReadLine());
            c = (f - 32) * 5 / 9;
            Console.WriteLine("The temperature in Celsius is: " + c);
            Console.ReadLine();
        }
    }
}
