using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, sum;

            Console.WriteLine("Please enter 2 numbers:");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            sum = x;
            for (int i = 1; i < y; i++)
            {
                sum += x;
            }
            Console.WriteLine(sum);
                Console.ReadLine();
        }
    }
}
