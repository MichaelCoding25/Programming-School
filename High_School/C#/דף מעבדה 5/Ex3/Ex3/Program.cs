using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 100; i++)
            {
                if ((i / 10 == 7) || (i % 10 == 7) || (i == 7) || (i % 7 == 0))
                {
                    Console.WriteLine(" Boom");
                }
                else
                {
                    Console.WriteLine(" " + i);
                }
            }

                Console.ReadLine();
        }
    }
}
