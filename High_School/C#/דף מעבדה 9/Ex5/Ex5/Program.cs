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
            for (int i = 1; i < 201; i++)
            {
                if (IsBoom(i))
                {

                    Console.Write("Boom");
                    Console.Write(" ");
                }
                else
                {

                    Console.Write(i);
                    Console.Write(" ");
                }
            }

            Console.ReadLine();
        }

        static bool IsBoom(int num)
        {
            if(num % 10 == 7 || num / 10 == 7 || num / 10 % 10 == 7 || num % 7 == 0)
            {
                return true;
            }
            return false;
        }
    }
}
