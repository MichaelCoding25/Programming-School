using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, max;
            num1 = -30;
            num2 = 13;
            max = MyMax(num1, num2);
            Console.WriteLine("Numbers: {0}, {1}.\nThe biggest is: {2}", num1, num2, max);
            num1 = 88;
            num2 = 62;
            max = MyMax(num1, num2);
            Console.WriteLine("Numbers: {0}, {1}.\nThe biggest is: {2}", num1, num2, max);
            Console.ReadLine();
        }
        static int MyMax(int n1, int n2)
        {
            if (n1 > n2)
                return n1;
            else
                return n2;
        }
    }
}
