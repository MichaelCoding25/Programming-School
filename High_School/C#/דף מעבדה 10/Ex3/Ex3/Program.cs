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
            string input = "";
            int len;
            while(input != "finish")
            {
                Console.WriteLine("Please enter a word:");
                input = Console.ReadLine();
                len = input.Length;
                len = len / 2;
                if(input != "finish")
                {
                    Console.WriteLine("");
                    Console.WriteLine(input.Insert(len, "-"));
                    Console.WriteLine("");
                }

            }

            Console.ReadLine();
        }
    }
}
