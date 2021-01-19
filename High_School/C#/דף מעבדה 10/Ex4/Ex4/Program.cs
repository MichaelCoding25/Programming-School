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
            string input, output;
            int dot1, dot2, range;

            Console.WriteLine("Enter a website URL:");
            input = Console.ReadLine();
            dot1 = input.IndexOf(".");
            dot2 = input.IndexOf(".", dot1 + 1);
            range = dot2 - dot1 - 1;
            output = input.Substring(dot1 + 1, range);
            Console.WriteLine("");
            Console.WriteLine("The name of the website is: " + output);

            Console.ReadLine();
        }
    }
}
