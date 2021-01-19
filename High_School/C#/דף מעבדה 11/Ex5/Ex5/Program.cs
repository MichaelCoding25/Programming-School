using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] heights = new int[10];
            int sum = 0;
            double average;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter your height in centimeters:");
                heights[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("");
                sum += heights[i];
            }
            average = sum / 10;
            Console.WriteLine("The average of the heights is " + average + "cm");
            Console.WriteLine("Here are all of the heights that exceed the average:");
            for (int n = 0; n < 10; n++)
            {
                if (heights[n] > average)
                {
                    Console.Write(heights[n] + " ");
                }
            }

            Console.ReadLine();
        }
    }
}
