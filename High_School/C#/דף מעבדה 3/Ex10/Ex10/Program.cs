using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            char bigLetter, smallLetter;
            Console.WriteLine("Please enter the capital letter:");
            bigLetter = char.Parse(Console.ReadLine());
            smallLetter = (char)(bigLetter + 32);
            Console.WriteLine(smallLetter);
            Console.ReadLine();
        }
    }
}
