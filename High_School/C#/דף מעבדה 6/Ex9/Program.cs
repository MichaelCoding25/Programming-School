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
            double input, highest, counter = 0;
            Console.WriteLine("Please enter your height in meters:");
            input = double.Parse(Console.ReadLine());
            highest = input;
            if (input > 1.80)
                counter++;
            while (input != 0)
            {
                Console.WriteLine("Please enter your height in meters:");
                input = double.Parse(Console.ReadLine());
                if (input > highest)
                    highest = input;
                if (input > 1.80)
                    counter++;
            }
            Console.WriteLine("The tallest height is: " + highest);
            Console.WriteLine("The number of students which are taller then 1.80m is: " + counter);


            Console.ReadLine();
        }
    }
}
