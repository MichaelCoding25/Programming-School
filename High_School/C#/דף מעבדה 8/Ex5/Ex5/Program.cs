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
            int counter1 = 0, input = 0, sum = 0, counter2 = 0, average;
            for (int i = 0; i < 4; i++)
            {
                counter1 = -1;
                input = 0;
                while (input != -999)
                {
                    sum += input;
                    counter1++;
                    Console.WriteLine("Enter a grade");
                    input = int.Parse(Console.ReadLine());

                }
                average = sum / counter1;
                Console.WriteLine("The average is {0}", average);
                if (average > 90)
                    counter2++;
            }
            Console.WriteLine("The number of excellent students is {0}", counter2);


            Console.ReadLine();
        }
    }
}
