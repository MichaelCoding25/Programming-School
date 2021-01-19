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
            int[] nums = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter a number:");
                nums[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("");
            }
            for (int n = 0; n < 5; n++)
			{
                Console.Write(nums[n]*2);
                Console.Write(" ");
			 
			}

            Console.ReadLine();
        }
    }
}
