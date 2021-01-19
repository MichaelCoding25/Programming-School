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
            int input, highest, lowest;
            Console.WriteLine("Please enter your score:");
            input = int.Parse(Console.ReadLine());
            highest = input;
            lowest = input;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Please enter your score:");
                input = int.Parse(Console.ReadLine());
                if (input > highest)
                {
                    highest = input;
                }
                else if (input < lowest)
                {
                    lowest = input;
                }
                
            }
            Console.WriteLine("The highest score is: " + highest + ", and the lowest score is: " + lowest);

            Console.ReadLine();
        }
    }
}
