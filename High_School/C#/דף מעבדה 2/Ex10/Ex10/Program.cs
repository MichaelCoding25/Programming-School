using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            int digit1, digit3, num;

            Console.WriteLine("Please enter a three digit number:");
            num = int.Parse(Console.ReadLine());
            digit1 = num / 100;
            digit3 = num % 10;
            if (digit1 == digit3)
            {
                Console.WriteLine("The number is a Palindrome");
            }
            else
            {
                Console.WriteLine("The number isn't a Palindrome");
            }
            Console.ReadLine();
        }
    }
}
