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
            int num;
            bool isIt = false;
            Console.WriteLine("Enter a number:");
            num = int.Parse(Console.ReadLine());
            while (num != 0 && isIt == false)
            {
                if (num % 10 == 5)
                {

                    isIt = true;
                }
                num = num / 10;
            }
            if (isIt == true)
                Console.WriteLine("This numbers contains the digit 5!");
            else
                Console.WriteLine("This number doesn't contain the digit 5.");
            Console.ReadLine();
        }
    }
}
