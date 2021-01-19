using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, absolute;

            Console.WriteLine("Enter a number:");
            num = int.Parse(Console.ReadLine());
            if (num > -1)
            {
                Console.WriteLine("The absolute value of " + num + " is: " + num);
            }
            else
            {
                absolute = num * (-1);
                Console.WriteLine("The absolute value of " + num + " is: " + absolute);
            }
            Console.ReadLine();
        }
    }
}
