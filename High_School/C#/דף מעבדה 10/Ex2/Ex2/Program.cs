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
            string input = " ";
            while (input != "")
            {
                Console.WriteLine("Please write a sentence:");
                input = Console.ReadLine();
                input = input.Replace("shit", "sh*t").Replace("fuck", "f*ck").Replace("ass", "a**").Replace("nigga", "*****").Replace("nigger", "******").Replace("dick", "d*ck");
                Console.WriteLine("");
                if (input != "")
                {
                    Console.WriteLine("The profanity free sentence is:");
                    Console.WriteLine(input);
                    Console.WriteLine("");
                    Console.WriteLine("");
                }
                

            }

            Console.ReadLine();
        }
    }
}
