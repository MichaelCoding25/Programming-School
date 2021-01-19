using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    public class Rectangle
    {
        private int lenght = 0, width = 0;

        public void SetDimentions(int l, int w)
        {
            lenght = l;
            width = w;
        }

        public int Area()
        {
            return lenght * width;
        }

        public int Perimeter()
        {
            int p = (2 * lenght) + (2 * width);
            return p;
        }
        public void DrawRectangle()
        {
            for (int i = 0; i < lenght; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        
    }
}
