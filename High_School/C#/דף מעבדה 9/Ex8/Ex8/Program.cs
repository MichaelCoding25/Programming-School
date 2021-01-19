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
            int w, l;
            char charachter;
            for (int k = 0; k < 6; k++)
            {
                Console.WriteLine("Please enter the lenght, widthand the character which the rectangle will be built of:");
                l = int.Parse(Console.ReadLine());
                w = int.Parse(Console.ReadLine());
                charachter = char.Parse(Console.ReadLine());
                Console.WriteLine("");
                Rectangle(l, w, charachter);
                Console.WriteLine(""); 
            }

            Console.ReadLine();
        }
        static void Rectangle(int lenght, int width, char c)
        {
            for (int i = 0; i < lenght; i++)
            {
                for (int n = 0; n < width; n++)
                {
                    Console.Write(c);
                }
                Console.WriteLine("");
            }
        }
    }
}
