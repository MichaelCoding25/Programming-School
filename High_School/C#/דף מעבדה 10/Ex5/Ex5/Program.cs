using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = " ", sentence = "";

            Console.WriteLine("Please enter animal names and between each one press ENTER:");
            while (input != "")
            {
                input = Console.ReadLine();
                if (input != "")
                    sentence += (input + " * ");
            }
            Console.WriteLine("");
            Console.WriteLine(sentence);

            Console.ReadLine();
        }
    }
}
