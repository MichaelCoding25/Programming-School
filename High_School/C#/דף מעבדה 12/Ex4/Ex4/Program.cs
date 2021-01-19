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
            bool work;
            int[] arr1 = { 5, 3, 7, 1, 2, 6, 4 };
            int[] arr2 = { 8, 3, 8, 7, 6, 5, 4, 2 };
            int[] arr3 = { 3, 3, 2 };
            int[] arr4 = { 1,4,3,2};

            Console.Write ("The numbers on array number 1 ");
            if (isCorrect(arr1) == true)
            {
                Console.WriteLine("are tmura");
            }
            else
                Console.WriteLine("aren't tmura");

            Console.Write("The numbers on array number 2 ");
            if (isCorrect(arr2) == true)
            {
                Console.WriteLine("are tmura");
            }
            else
                Console.WriteLine("aren't tmura");

            Console.Write("The numbers on array number 3 ");
            if (isCorrect(arr3) == true)
            {
                Console.WriteLine("are tmura");
            }
            else
                Console.WriteLine("aren't tmura");

            Console.Write("The numbers on array number 4 ");
            if (isCorrect(arr4) == true)
            {
                Console.WriteLine("are tmura");
            }
            else
                Console.WriteLine("aren't tmura");



            Console.ReadLine();
        }
        static bool isCorrect(int[] nums)
        {
            int[] count = new int[nums.Length];
            bool isIt = true;
            int k = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                count[nums[i] - 1]++;
            }
            while (isIt == true && k < nums.Length) 
            {
                if (count[k] != 1)
                    isIt = false;
                k++;
            }
            if (isIt == false)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
