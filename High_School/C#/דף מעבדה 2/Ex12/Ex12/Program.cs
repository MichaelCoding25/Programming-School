using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, hour, min, pm;

            Console.WriteLine("Please enter an hour:");
            num = int.Parse(Console.ReadLine());
            hour = num / 100;
            min = num % 100;
            if (hour > 12)
            {
                pm = hour - 12;
                Console.WriteLine(pm + ":" + min + " p.m.");

            }
            else
            {
                Console.WriteLine(hour + ":" + min + " a.m.");
            }

            Console.ReadLine();
        }
    }
}
