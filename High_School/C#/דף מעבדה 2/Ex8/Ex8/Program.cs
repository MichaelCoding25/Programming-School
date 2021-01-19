using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number between 1 to 99: ");
            int n = int.Parse(Console.ReadLine());

            if (n % 7 == 0 || n / 10 == 7 || n % 10 == 7)
                Console.WriteLine("BOOM!");
            
            Console.ReadLine();
        }
    }
}
