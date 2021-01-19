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
            int target = 50, input, total = 0, morethen, counter = 0;
            while (total < target)
            {
                Console.WriteLine("Please enter the number of meters you moved the rock this time:");
                input = int.Parse(Console.ReadLine());
                total += input;
                counter++;
            }
            if (total > target)
            {
                morethen = total - target;
                Console.WriteLine("The rock was moved 50 meters in " + counter + " attempts and he moved the rock " + morethen + " meters more than needed.");
            }
            else
                Console.WriteLine("The rock was moved 50 meters in " + counter + " attempts");


            Console.ReadLine();
        }
    }
}
