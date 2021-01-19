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
            int num;
            char equal;
            Console.WriteLine("Please enter a number:");
            num = int.Parse(Console.ReadLine());
            equal = (char)num;
            Console.WriteLine(equal);
            Console.ReadLine();

        }
    }
}
