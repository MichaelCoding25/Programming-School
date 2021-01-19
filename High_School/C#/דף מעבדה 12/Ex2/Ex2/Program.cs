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
            int[] nums = new int[6];
            int num;
            Random randNum = new Random();
            for (int i = 0; i < 100; i++)
            {
                num = randNum.Next(1, 7);
                nums[num - 1]++;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine("The number " + (i+1) + " was drawn " + nums[i] + " times.");
            }

            Console.ReadLine();
        }
    }
}
