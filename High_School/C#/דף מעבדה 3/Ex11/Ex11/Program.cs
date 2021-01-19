using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11
{
    class Program
    {
        static void Main(string[] args)
        {
            int zela1, zela2, zela3;
            Console.WriteLine("Please enter the three sides of the triangle:");
            zela1 = int.Parse(Console.ReadLine());
            zela2 = int.Parse(Console.ReadLine());
            zela3 = int.Parse(Console.ReadLine());
            if (zela1 == zela2 && zela2 == zela3)
                Console.WriteLine("It's an equilateral triangle");
            else if (zela1 == zela2 || zela1 == zela3 || zela2 == zela3)
                Console.WriteLine("It's an isosceles triangle");
            else
                Console.WriteLine("It's a regular triangle");
            Console.ReadLine();
        }
    }
}
