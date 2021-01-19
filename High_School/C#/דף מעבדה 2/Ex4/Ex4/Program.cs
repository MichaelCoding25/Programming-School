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
            int age;

            Console.WriteLine("How old are you?");
            age = int.Parse(Console.ReadLine());
            if (age > 12 && age < 20)
            {
                Console.WriteLine("You're a teenager!");
            }
            else
            {
                Console.WriteLine("You are not a teen.");
            }

            Console.ReadLine();
        }
    }
}
