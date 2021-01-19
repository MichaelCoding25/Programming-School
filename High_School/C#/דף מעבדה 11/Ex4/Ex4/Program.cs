using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = new string[4];
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Please enter a string:");
                arr[i] = Console.ReadLine();
                Console.WriteLine("");
            }
            for (int n = 0; n < 4; n++)
            {
                if (arr[n].Length > 10)
                {
                    Console.WriteLine(arr[n]);
                }
            }

            Console.ReadLine();
        }
    }
}
