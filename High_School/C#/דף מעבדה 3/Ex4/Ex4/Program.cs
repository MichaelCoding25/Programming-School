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
            char sign, lower, higher;
            Console.WriteLine("Please enter a key:");
            sign = char.Parse(Console.ReadLine());
            lower = (char)(sign - 1);
            higher = (char)(sign + 1);
            Console.WriteLine(lower + " " +higher);
            Console.ReadLine();
        }
    }
}
