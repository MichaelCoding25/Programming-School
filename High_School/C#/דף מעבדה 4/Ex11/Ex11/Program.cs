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
            int X, Y, sum;
            sum = 1;
            Console.WriteLine("Please enter 2 number:");
            X = int.Parse(Console.ReadLine());
            Y = int.Parse(Console.ReadLine());
            for(int i = 1; i<=Y; i++)
            {
                sum = sum * X;
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
