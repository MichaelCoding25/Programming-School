using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 800, 11, 50, 771, 649, 770, 240, 9 };

            BubbleSort(arr);

            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");

            


            Console.ReadLine();
        }

        //Input: An array of numbers
        //Output: Sorts the numbers from lowest to highest in the array
        static void BubbleSort(int[] arr)
        {
            int backup;
            for (int i = 1; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length-i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        backup = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = backup;
                    }
                }
            }
        }
    }
}
