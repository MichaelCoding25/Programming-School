    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page1_Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            int threeDigitNum, digit1, digit2, digit3, sum;
            Console.WriteLine("Please enter a three digit number:");
            threeDigitNum = int.Parse(Console.ReadLine());
            digit3 = threeDigitNum / 100;
            digit2 = (threeDigitNum % 100) / 10;
            digit1 = (threeDigitNum % 100) % 10;
            sum = digit3 + digit2 + digit1;
            Console.WriteLine("The sum of the digits is: " + sum);

            Console.WriteLine("Phase 2: " + digit3 + "00" + "+" + digit2 + "0" + "+" + digit1 + "=" + threeDigitNum);

            int reverse = 0;
            while (threeDigitNum > 0)
            {
                int rem = threeDigitNum % 10;
                reverse = (reverse * 10) + rem;
                threeDigitNum = threeDigitNum / 10;
            }
            Console.WriteLine("The reverse number is: " + reverse);

            Console.ReadLine();
        }
    }
}
