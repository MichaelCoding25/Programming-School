using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 13, 25, 36, 47, 94, 83, 72 };

            // Print the array's values... Should be:
            // 13 25 36 47 94 83 72
            Console.WriteLine("The original array:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

            Backwards(arr); // A

            // Print the array again... Should be:
            // 72 83 94 47 36 25 13
            Console.WriteLine("The array after Backwards:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.ReadLine();
        }
        static void Backwards(int[] arr)
        {
            int index = 0;
            int[] backwardsArr = new int[arr.Length];
            for (int i = arr.Length-1; i >-1; i--)
            {
                backwardsArr[index] = arr[i];
                index++;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = backwardsArr[i];
            }
        }
    }
}
