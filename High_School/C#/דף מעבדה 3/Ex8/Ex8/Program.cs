using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            double area, surround, radius, diameter;
            Console.WriteLine("Please enter the radius of the circle:");
            radius = double.Parse(Console.ReadLine());
            diameter = radius * 2;
            surround = Math.PI * diameter;
            area = Math.Pow(radius, 2) * Math.PI;
            Console.WriteLine("The diameter of the circle is: " + diameter + ", the surrounding is: " + surround + ", and the area is: " + area);
            Console.ReadLine();
        }
    }
}
