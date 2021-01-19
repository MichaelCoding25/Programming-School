using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[6];
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Enter a number:");
                arr[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("");
            }
            for (int n = 5; n >= 0 ; n--)
            {
                Console.Write(arr[n]);
                Console.Write(" ");
            }

            Console.ReadLine();
        }
    }
}
