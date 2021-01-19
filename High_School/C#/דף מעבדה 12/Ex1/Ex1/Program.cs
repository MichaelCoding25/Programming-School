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
            int[] arr = new int[5];
            int[] mults = new int[arr.Length];
            Console.WriteLine("Enter {0} numbers:", arr.Length);
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < arr.Length; i++)
            {
                mults[i] = arr[i] * 2;
            }
            Console.WriteLine("");
            Console.WriteLine("The original numbers are:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("The numbers multiplied by two are:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(mults[i] + " ");
            }

            Console.ReadLine();
        }
    }
}
