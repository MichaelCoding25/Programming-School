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
            int low, high, divider;
            Console.WriteLine("Please enter the lowest number, highest one and the divider:");
            low = int.Parse(Console.ReadLine());
            high = int.Parse(Console.ReadLine());
            divider = int.Parse(Console.ReadLine());
            for (int i = low; i <= high; i++)
            {
                if (i % divider == 0)
                {
                    Console.Write(i);
                    Console.Write(" ");
                }
            }
                Console.ReadLine();
        }
    }
}
