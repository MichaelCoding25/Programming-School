using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            Console.WriteLine("Please enter a sentence:");
            input = Console.ReadLine();

            if(input.IndexOf("waldo") != -1)
                Console.WriteLine("The length of this sentence is " + input.Length + " charachters and the word waldo exists in this sentence.");
            else
                Console.WriteLine("The length of this sentence is " + input.Length + " charachters and the word waldo doesn't exists in this sentence.");
            Console.ReadLine();
        }
    }
}
