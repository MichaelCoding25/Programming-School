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
            int[] hey = { 800, 11, 50, 771, 649, 770, 240, 9 };

            SelectionSort(hey);

            for (int i = 0; i < hey.Length; i++)
                Console.Write(hey[i] + " ");




            Console.ReadLine();
        }

        //Input: An array of numbers
        //Output: Sorts the numbers from lowest to highest
        static void SelectionSort(int[] arr)
        {
            int pos_min, temp;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                pos_min = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[pos_min])
                    {
                        
                        pos_min = j;
                    }
                }
                if (pos_min != i)
                {
                    temp = arr[i];
                    arr[i] = arr[pos_min];
                    arr[pos_min] = temp;
                }
            }
        }
    }
}
