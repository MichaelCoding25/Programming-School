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
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine();
                for (int n = 1; n < 11; n++)
                {
                    Console.Write(i*n);
                    Console.Write(" ");
                }
            }



            Console.ReadLine();
        }
    }
}
