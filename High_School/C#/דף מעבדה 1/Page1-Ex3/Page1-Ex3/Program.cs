using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page1_Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int twoDigitNum, sum, threeDigitNum, digit2, digit1;
            string str2;

            Console.WriteLine("Please enter a positive two digit number:");
            str2 = Console.ReadLine();
            twoDigitNum = int.Parse(str2);
            digit1 = twoDigitNum % 10;
            digit2 = twoDigitNum / 10;
            sum = digit1 + digit2;

            Console.WriteLine("The sum of the two digits are: " + sum + ", the three digit number is: " + digit1 + str2);

            Console.ReadLine();
        }
    }
}
