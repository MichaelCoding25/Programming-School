using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int hefresh, age1, age2;
            char gen1, gen2;

            Console.WriteLine("Please state the genders and ages of your pigeons with letters and numbers:");
            gen1 = char.Parse(Console.ReadLine());
            age1 = int.Parse(Console.ReadLine());
            gen2 = char.Parse(Console.ReadLine());
            age2 = int.Parse(Console.ReadLine());

            hefresh = age1 - age2;
            if (hefresh < 0)
            {
                hefresh = hefresh * (-1);
            }

            if (gen2 != gen1)
            {
                if (0 <= hefresh && hefresh <= 5)
                {
                    Console.WriteLine("Compatible");
                }
                else
                {
                    Console.WriteLine("Not Compatible");
                }
            }
            else
            {
                Console.WriteLine("Not Compatible");
            }

            Console.ReadLine();
        }
    }
}
