using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            for(int i = 1; i <=6; i++)
            {
                Console.WriteLine("Please enter a number:");
                num = int.Parse(Console.ReadLine());
                if (num < 10)
                {
                    Console.WriteLine("The number is one digit");
                }
                else if (num >9 && num < 100)
                {
                    Console.WriteLine("The number is a 2 digit number");
                }
                else
                {
                    Console.WriteLine("Other");
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}
