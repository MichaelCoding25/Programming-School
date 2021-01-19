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
            int[] month = new int[12];
            int monthMax, monthMin, minCounter, maxCounter;
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine("Enter how many babys were born in the month number " + (i + 1) + ":");
                month[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("");
            }
            monthMax = month[0];
            maxCounter = 0;
            monthMin = month[0];
            minCounter = 0;
            for (int n = 1; n < 12; n++)
            {
                if (month[n] > monthMax)
                {
                    monthMax = month[n];
                    maxCounter = n;
                }
                else if (month[n] < monthMin)
                {
                    monthMin = month[n];
                    minCounter = n;
                }
            }
            Console.WriteLine("The month with the most babies is month number " + (maxCounter + 1));
            Console.WriteLine("The month with the least babies is month number " + (minCounter + 1));

            Console.ReadLine();
        }
    }
}
