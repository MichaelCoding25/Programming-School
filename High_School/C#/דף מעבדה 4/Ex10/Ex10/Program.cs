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
            int X, Y, sum;
            sum = 0;
            Console.WriteLine("Please enter two numbers:");
            X = int.Parse(Console.ReadLine());
            Y = int.Parse(Console.ReadLine());
            for (int i = 0; i<Y; i++)
            {
                sum = sum + X;
            }
            Console.WriteLine("The sum is: " + sum);
            Console.ReadLine();
        }
    }
}
