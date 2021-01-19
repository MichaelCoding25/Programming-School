using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            Console.WriteLine("Please enter a number:");
            input = int.Parse(Console.ReadLine());
            while (input != 0)
            {
                Console.WriteLine("The absoulute is: " + MyAbs(input));
                Console.WriteLine("2 in the power of " + input + " is " + MyPow(2,input));
                Console.WriteLine("");
                Console.WriteLine("Please enter a number:");
                input = int.Parse(Console.ReadLine());
            }

                

            Console.ReadLine();
        }
        static int MyAbs(int num)
        {
            if (num < 0)
            {
                num = num * (-1);
                return num;
            }
            else
                return num;


        }
        static int MyPow(int baseNum, int power)
        {
            int result = 1;

            for (int i = 0; i < power; i++)
            {
                result = result * baseNum;
            }
            return result;
        }
    }
}
