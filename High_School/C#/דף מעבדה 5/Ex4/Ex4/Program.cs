using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            double num, positive, negetive;
            positive = 0;
            negetive = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Please enter a number:");
                num = double.Parse(Console.ReadLine());
                if (num > 0)
                {
                    positive = positive + 1;
                }
                else if (num < 0)
                {
                    negetive = negetive + 1;
                }
            }
            Console.WriteLine("You entered " + positive + " positive numbers, and " + negetive + " negetive numbers.");
            if (positive > negetive)
                Console.WriteLine("You entered more positive then negetive numbers.");
            else if (negetive > positive)
                Console.WriteLine("You entered more negetive then positive numbers.");
            else
                Console.WriteLine("You entered the same amount of negetive and positive numbers.");
                Console.ReadLine();
        }
    }
}
