using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            Console.WriteLine("Enter a word:");
            input = Console.ReadLine();
            StarName(input);

            Console.ReadLine();
        }
        static void StarName(string word)
        {
            int len = word.Length;
            for (int i = 0; i < len + 4; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
            Console.WriteLine("* " + word + " *");
            for (int i = 0; i < len + 4; i++)
            {
                Console.Write("*");
            }
        }
    }
}
