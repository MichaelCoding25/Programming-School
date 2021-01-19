using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            int indNeg = 0, indPos = 0;
            int[] numbers = new int[6];
            int[] positive = new int[6];
            int[] negetive = new int[6];    
            Console.WriteLine("Enter 6 negetive and positive numbers:");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] > 0)
                {
                    positive[indPos] = numbers[i];
                    indPos++;
                }
                else if(numbers[i] < 0)
                {
                    negetive[indNeg] = numbers[i];
                    indNeg++;
                }
            }
            Console.WriteLine("The positive numbers are:");
            for (int i = 0; i < indPos; i++)
            {
                Console.Write(positive[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("The negetive numbers are:");
            for (int i = 0; i < indNeg; i++)
            {
                Console.Write(negetive[i] + " ");
            }

            Console.ReadLine();
        }
    }
}
