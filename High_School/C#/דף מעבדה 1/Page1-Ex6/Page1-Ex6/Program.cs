using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page1_Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int grade;

            Console.WriteLine("Please enter your name:");
            name = Console.ReadLine();
            Console.WriteLine("Please enter your grade:");
            grade = int.Parse(Console.ReadLine());

            if (grade > 55)
            {
                Console.WriteLine(name + " Passed.");
            }
            else
            {
                Console.WriteLine(name + " Failed.");
            }
            Console.ReadLine();
        }
    }
}
