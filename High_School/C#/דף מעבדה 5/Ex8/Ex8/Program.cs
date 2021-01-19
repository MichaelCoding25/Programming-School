using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = 0, max = 0, counter = 0;
            for (int i = 1; i <= 8; i++)
            {
                Console.WriteLine("Please enter your score:");
                num1 = double.Parse(Console.ReadLine());
                if (num1 > max)
                {
                    max = num1;
                    counter = i;
                }
            }
            Console.WriteLine("The highest jump was: " + max + " and it was number " + counter);

            Console.ReadLine();
        }
    }
}
