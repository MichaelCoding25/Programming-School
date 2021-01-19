using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page1_Ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            int id, digit;
            Console.WriteLine("Please enter your 9 digit ID number:");
            id = int.Parse(Console.ReadLine());
            digit = id % 10;
            if (digit == 3)
                Console.WriteLine("You won");
            else
                Console.WriteLine("You didn't win");
            Console.WriteLine("");
            Console.WriteLine("Have a good day!");
            Console.ReadLine();
        }
    }
}
