using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            string name, card;
            Console.WriteLine("Please enter your name and age:");
            name = Console.ReadLine();
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            card = ("Happy BDay " + name + " for your " + age + " birthday");
            StarName(card);
            Console.WriteLine("");
            Console.WriteLine("And here's a rectangle with your age:");
            Rectangle(age);

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
        static void Rectangle(int length)
        {
            for (int i = 0; i < length; i++)
            {
                for (int n = 0; n < 100; n++)
                {
                    Console.Write("@");
                }
                Console.WriteLine("");
            }
        }
    }
}
