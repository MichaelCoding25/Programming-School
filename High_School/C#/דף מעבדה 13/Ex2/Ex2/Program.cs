using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 14, 20, 3, 55, 43, 71, 27, 39, 22, 8 };
            int num;
            int index;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Please enter a number to find:");
                num = int.Parse(Console.ReadLine());
                index = ArrayIndexOf(arr, num); // A
                if (index >= 0)
                {
                    Console.WriteLine("The number " + num + " is in the array at index " + index);

                }
                else
                {
                    Console.WriteLine("The number is not in the array...");
                }
            }
            Console.ReadLine();
        }
        // Input: An array and a number to find in it.
        // Output: Returns the index of the number we wanted to find.
        static int ArrayIndexOf(int[] arr, int num)
        {
            int which = -1;
            int i = 0;
            bool isIt = false;
            while (i < arr.Length && isIt == false)
            {
                if (arr[i] == num)
                {
                    which = i;
                    isIt = true;
                }
                i++;
            }
            return which;
        }
    }
}
