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
            string input;

            int numberOfSpaces = 0, lastSpace = 0, space = 0;

            Console.WriteLine("Write a sentence:");
            input = Console.ReadLine();
            space = input.IndexOf(" ");
            while (space != -1)
            {      
                numberOfSpaces++;
                lastSpace = space;
                space = input.IndexOf(" ", lastSpace+1);
            }
            Console.WriteLine("");
            Console.WriteLine("The number of words in the sentence are: " + (numberOfSpaces + 1));
            Console.ReadLine();
        }
    }
}
