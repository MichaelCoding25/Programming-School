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
            int[,] mat = new int[5, 5] 
            {
                {1,   2,   3,   4,   5},
                {6,   7,   8,   9,   10},
                {11, 12, 13, 14, 15},
                {16, 17, 18, 19, 20},
                {21, 22, 23, 24, 25},
            };

            D(mat);
            Console.ReadLine();
        }
        static void A(int[,] arr1)
        {
            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                Console.Write(arr1[0, i] + " ");
            }
            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                Console.Write(arr1[arr1.GetLength(0) - 1, i] + " ");
            }
        }
        static void B(int[,] arr2)
        {
            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                Console.Write(arr2[i, i] + " ");
            }
        }
        static void C(int[,] arr3)
        {
            for (int i = 0; i < arr3.GetLength(0); i++)
            {
                Console.Write(arr3[i, arr3.GetLength(0) - 1 - i] + " ");
            }
        }
        static void D(int[,] arr4)
        {
            for (int i = 0; i < arr4.GetLength(0)-1; i++) 
            {
                for (int j = i + 1; j < arr4.GetLength(1); j++)
                {
                    Console.Write(arr4[i, j] + " ");
                }
            }
        }
    }
}
