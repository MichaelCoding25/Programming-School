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
            int num, sum = 0, counter = 0, lastnum, hefresh, smallhefresh = 9999999, avrg, smallestdifnum1 = 0, smallestdifnum2 = 0;

            Console.WriteLine("Please enter a number");
            num = int.Parse(Console.ReadLine());
            sum += num;
            lastnum = num;
            for (int i = 0; i<6; i++)
            {
                 
                Console.WriteLine("Please enter a number");
                num = int.Parse(Console.ReadLine());
                sum += num;
                if (i == 2)
                    counter = num;
                hefresh = num - lastnum;
                if (hefresh < smallhefresh)
                {
                    smallhefresh = hefresh;
                    smallestdifnum1 = num;
                    smallestdifnum2 = lastnum;
                }
                lastnum = num;
            }
            avrg = sum / 7;
            Console.WriteLine("The average is " + avrg);
            Console.WriteLine("The 2 numbers with the smallest hefresh are " + smallestdifnum2 + ", " + smallestdifnum1);
            Console.WriteLine("The middle number is " + counter);

            Console.ReadLine();
        }
    }
}
