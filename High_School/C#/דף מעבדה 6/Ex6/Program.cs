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
            int n, sec, first, second;
            Console.WriteLine("Please enter the number of cars that have participated in the race:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your score in seconds:");
            sec = int.Parse(Console.ReadLine());
            first = sec;
            second = sec;
            for (int i = 0; i < (n - 1); i++)
            {
                Console.WriteLine("Please enter your score in seconds:");
                sec = int.Parse(Console.ReadLine());
                if (sec < first)
                {
                    first = sec;
                }
                else if (sec < second && sec > first)
                {
                    second = sec;
                }

            }
            Console.WriteLine("The fastest time is:" + first + ", and the second fastest time is: " + second);


            Console.ReadLine();
        }
    }
}
