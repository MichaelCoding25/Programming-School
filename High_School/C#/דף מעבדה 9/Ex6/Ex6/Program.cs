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
            string name, age;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Please enter your name and age:");
                name = Console.ReadLine();
                age = Console.ReadLine();
                Console.WriteLine("");
                BirthdayCard(name, age);
                Console.WriteLine("");

            }

            Console.ReadLine();
        }
        static void BirthdayCard(string n, string a)
        {
            Console.WriteLine("Happy BDay {0} for your {1} birthday!", n, a);
        }
    }
}
