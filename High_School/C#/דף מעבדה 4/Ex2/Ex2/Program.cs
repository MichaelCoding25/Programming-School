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
            for(int i = 10; i <= 40; i++)
            {
                Console.Write(i);
                Console.Write(" ");
            }
            Console.WriteLine("");
            for(int n = 65; n<=93; n+=2)
            {
                Console.Write(n);
                Console.Write(" ");
            }
            Console.ReadLine();
        }
    }
}
