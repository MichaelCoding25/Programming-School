using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, sum;
            char key;
            Console.WriteLine("Enter 2 numbers and then an arithmatic action:");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            key = char.Parse(Console.ReadLine());
            switch (key)
            {
                case '/':
                    sum = num1 / num2;
                    break;
                case '*':
                    sum = num1 * num2;
                    break;
                case '+':
                    sum = num1 + num2;
                    break;
                case '-':
                    sum = num2 - num2;
                    break;
                default:
                    sum = 0;
                    break;
            }
            Console.WriteLine("The number is: " + sum);
            Console.ReadLine();
        }
    }
}
