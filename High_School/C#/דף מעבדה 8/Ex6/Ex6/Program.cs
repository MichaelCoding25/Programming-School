using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght, height;
            Console.WriteLine("Enter height and lenght");
            height = int.Parse(Console.ReadLine());
            lenght = int.Parse(Console.ReadLine());
            for (int i = 0; i < height; i++)
            {
                for (int n = 0; n < lenght; n++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

            Console.ReadLine();
        }
    }
}
