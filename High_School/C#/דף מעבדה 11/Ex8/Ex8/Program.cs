using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, n = 1;
            bool isIt = true;
            Console.WriteLine("Enter the number of numbers you want to enter:");
            num = int.Parse(Console.ReadLine());
            int[] arr = new int[num];

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Enter a number:");
                arr[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("");
            }
            while ((isIt == true) && (n < num))
            {
                if (arr[n] < arr[n - 1])
                {
                    isIt = false;
                }
                n++;
            }
            if(isIt == true)
                Console.WriteLine("The numbers are in a rising order");
            else
                Console.WriteLine("The numbers are not in a rising order");

            Console.ReadLine();
        }
    }
}
