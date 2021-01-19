using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Please enter a positive number:");
            num = int.Parse(Console.ReadLine());
            if (num > 0)
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine("Even");
                }
                else
                {
                    Console.WriteLine("Not Even");
                }
            }
            else
            {
                Console.WriteLine("Error, Goodbye!");
            }
            Console.ReadLine();
            
        }
    }
}
