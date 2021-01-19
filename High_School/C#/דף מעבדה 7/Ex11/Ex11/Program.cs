using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11
{
    class Program
    {
        static void Main(string[] args)
        {
            double square, n, i = 2;
            bool check = false;
            Console.WriteLine("Please enter a number:");
            n = int.Parse(Console.ReadLine());
            square = Math.Sqrt(n);
            while (check != true && i <= square)
            {
                if (n % i == 0)
                    check = true;
                i++;
            }
            if (check == true)
                Console.WriteLine("It isn't a prime number");
            else
                Console.WriteLine("It's a prime number");
            Console.ReadLine();
        }
    }
}
