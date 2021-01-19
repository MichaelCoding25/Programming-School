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
            int num;
            Console.WriteLine("Please enter a number:");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.Write("Your number divides by: ");
            for(int i = 1; i<=num; i++)
            {
                if (num % i == 0)
                {
                    Console.Write(i);
                    Console.Write(" ");
                }
            }
            Console.ReadLine();
        }
    }
}
