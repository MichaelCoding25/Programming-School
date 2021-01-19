using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.WriteLine("Please enter two numbers, line after line:");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());

            if(num1>0 && num2 > 0)
            {
                Console.WriteLine("Both numbers are positive.");
            }
            else if (num1 < 0 && num2 < 0)
            {
                Console.WriteLine("Both numbers are negetive.");
            }
            else if(num1 > 0 || num2 > 0)
            {
                Console.WriteLine("One of the numbers is positive");
            }
            else
                Console.WriteLine("One or both numbers equal 0");
            Console.ReadLine();
        }
    }
}
