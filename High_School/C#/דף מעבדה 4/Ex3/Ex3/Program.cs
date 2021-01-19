using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Please enter a number:");
            num = int.Parse(Console.ReadLine());
            for(int i = 0; i < num; i++)
            {
                Console.Write("*");
            }
            Console.ReadLine();
        }
    }
}
