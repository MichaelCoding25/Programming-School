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
            int N;
            Console.WriteLine("Please enter the size of the array:");
            N = int.Parse(Console.ReadLine());
            int[] array = new int[N];
            InsertRandom(array, 10, 100);
            Console.WriteLine("The random array is:");
            PrintArray(array);


            Console.ReadLine();
        }
        static void InsertRandom(int[] arr, int low, int high)
        {
            Random randnum = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = randnum.Next(low, high);
            }
        }
        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
