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
            int num, total = 0;
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("Please enter the number of students in bus number " + (i+1) + ":");
                num = int.Parse(Console.ReadLine());
                total += num;
            }
            Console.WriteLine("The total number of students is: " + total);

                Console.ReadLine();
        }
    }
}
