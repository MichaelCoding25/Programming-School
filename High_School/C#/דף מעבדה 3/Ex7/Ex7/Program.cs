using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenght, width, area, diagonal;
            Console.WriteLine("Enter the lenght and the width of the rectangle:");
            lenght = int.Parse(Console.ReadLine());
            width = int.Parse(Console.ReadLine());
            diagonal = (Math.Pow(lenght, 2)) + (Math.Pow(width, 2));
            area = lenght * width;
            Console.WriteLine("The area is: " + area + " and the diagonal is: " + diagonal);
            Console.ReadLine();
        }
    }
}
