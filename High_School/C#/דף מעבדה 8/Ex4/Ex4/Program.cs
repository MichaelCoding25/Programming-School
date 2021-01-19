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
            int num1 = 0, num2 = 1, n;

            while (num1 != num2)
            {
                Console.WriteLine("Please enter 2 numbers:");
                num1 = int.Parse(Console.ReadLine());
                num2 = int.Parse(Console.ReadLine());
                n = num1;
                if (num1 != num2)
                {
                    while (n <= num2)
                    {
                        Console.Write(n + " ");
                        n++;
                    }
                    Console.WriteLine("");
                }
            }
            Console.ReadLine();
        }
    }
}
