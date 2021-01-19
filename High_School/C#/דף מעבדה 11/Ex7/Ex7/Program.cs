using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[8];
            int evenSum = 0, oddSum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Please enter a number");
                arr[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("");
            }
            for (int n = 0; n < arr.Length; n+=2)
            {
                evenSum += arr[n];
            }
            for (int k = 1; k < arr.Length; k+=2)
            {
                oddSum += arr[k];
            }
            if (evenSum > oddSum)
            {
                Console.WriteLine("The sum of the even numbers on the array is bigger and it is " + evenSum);
            }
            else if(oddSum > evenSum)
            {
                Console.WriteLine("The sum of the odd numbers on the array is bigger and it's " + oddSum);
            }
            else
            {
                Console.WriteLine("The sums are even and they are " + oddSum);
            }

            Console.ReadLine();
        }
    }
}
