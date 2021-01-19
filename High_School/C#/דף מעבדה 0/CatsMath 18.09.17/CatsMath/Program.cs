using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatsMath
{
    class Program
    {
        static void Main(string[] args)
        {
            double width, length;
            double area, sum;
            Console.WriteLine("Please state the width of the rectangle:");
            width = double.Parse(Console.ReadLine());
            Console.WriteLine("Please state the length of the rectangele:");
            length = double.Parse(Console.ReadLine());
            area = (width * length);
            sum = ((width * 2)+(length * 2));
            Console.WriteLine("The area of the rectangle is: " + area + ", and the sum of all the sides is: " + sum);
            Console.ReadLine();
        }
    }
}
