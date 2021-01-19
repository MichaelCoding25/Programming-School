using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 7; i++)
            {
                for (int n = 1; n < 7; n++)
                {
                    Console.WriteLine("({0}, {1})", i, n);
                }
            }
            Console.ReadLine();
        }
    }
}
