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
            int inputLenght, inputWidth;

            Rectangle rec = new Rectangle();
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Enter the lenght and width of the rectangle number " + (i + 1) + ":" );
                inputLenght = int.Parse(Console.ReadLine());
                inputWidth = int.Parse(Console.ReadLine());
                rec.SetDimentions(inputLenght, inputWidth);
                Console.WriteLine("The area of the rectangle is: " + rec.Area());
                Console.WriteLine("The perimeter of the rectangle is: " + rec.Perimeter());
                Console.WriteLine();
                Console.WriteLine("The drawing of the rectangle:");
                rec.DrawRectangle();
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
