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
            int high, high2;
            Random random = new Random();
            int num1 = random.Next(20, 41);

            int num2 = random.Next(20, 41);

            int num3 = random.Next(20, 41);
            Console.WriteLine("The three random numbers are: " + num1 + ", " + num2 + ", " + num3);
            high = Math.Max(num1, num2);
            high2 = Math.Max(num2, num3);
            Console.WriteLine("The highest number is: " + high2);
            Console.ReadLine();

        }
    }
}
