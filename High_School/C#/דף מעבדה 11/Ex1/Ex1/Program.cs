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
            int[] arr = new int[3];
            Console.WriteLine("Enter 2 numbers:");
            arr[0] = int.Parse(Console.ReadLine());
            arr[1] = int.Parse(Console.ReadLine());
            arr[2] = arr[0] + arr[1];

            Console.WriteLine("These are the 3 numbers: " + arr[0] + ", " + arr[1] + ", " + arr[2]);
            Console.ReadLine();
        }
    }
}
