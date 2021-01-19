using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_1
{
    class Program
    {
        static void Main(string[] args)
        {
            DrawLine();
            DrawSquare();
            DrawLine();
            DrawSquare();
            DrawLine();

            Console.ReadLine();
        }
        static void DrawLine()
        {
            Console.WriteLine("##########");
        }
        static void DrawSquare()
        {
            Console.WriteLine("@@@");
            Console.WriteLine("@@@");
            Console.WriteLine("@@@");
        }
    }
}
