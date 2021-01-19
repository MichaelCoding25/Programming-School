using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_2
{
    class Program
    {
        static void Main(string[] args)
        {
            DrawLine(1);
            DrawLine(2);
            DrawLine(3);
            DrawLine(4);
            DrawLine(5);
            Console.WriteLine();
            DrawLineSign(1, '$');
            DrawLineSign(2, '*');
            DrawLineSign(3, '%');
            DrawLineSign(4, '>');
            DrawLineSign(3, '%');
            DrawLineSign(2, '*');
            DrawLineSign(1, '$');

            Console.ReadLine();
        }
        static void DrawLine(int len)
        {
            for (int i = 0; i < len; i++)
            {
                Console.Write("#"); 
            }
            Console.WriteLine();
        }
        static void DrawLineSign(int len, char sign)
        {
            for (int i = 0; i < len; i++)
            {
                Console.Write(sign);
            }
            Console.WriteLine();
        }
    }
}
