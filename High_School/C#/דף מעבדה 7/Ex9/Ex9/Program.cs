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
            int n;
            long sum = 1;
            Console.WriteLine("Please enter a number:");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                sum = sum * i;
            }
            Console.WriteLine("The azeret is: " + sum);

                Console.ReadLine();
        }
    }
}
