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
            int n, tamrurError, error, passed, percent;
            passed = 0;
            Console.WriteLine("Please enter the number of test takers:");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("How many errors did he have on his tamrur questions?");
                tamrurError = int.Parse(Console.ReadLine());
                Console.WriteLine("How many general errors did he have?");
                error = int.Parse(Console.ReadLine());
                if (tamrurError == 0)
                {
                    if (error <= 3)
                    {
                        passed += 1;
                    }
                }
            }
            percent = passed / n * 100;
            Console.WriteLine("The number of people who passed is: " + passed);
            Console.WriteLine("The percantage of people who passed is: " + percent);

            Console.ReadLine();
        }
    }
}
