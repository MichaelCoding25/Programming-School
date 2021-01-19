using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;

            Console.WriteLine("Please enter three numbers, line after line:");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            num3 = int.Parse(Console.ReadLine());

            if (num1 > num2 && num2 > num3)
            {
                Console.WriteLine("The numbers were written in an descending rate.");
            }
            else if (num1 < num2 && num2 < num3)
            {
                Console.WriteLine("The numbers were written in an ascending rate.");
            }
            else
            {
                Console.WriteLine("The numbers were entered in a random order.");
            }
            Console.ReadLine();
        }
    }
}
