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
            Pen a1 = new Pen("red", "aaa", 10.0, 5.5);
            Pen a2 = new Pen("bbb");
            Pen a3 = new Pen("black", "ccc", 8.0, 12.5);    
            a1.SetPrice(15.0);
            if (!(a1.IsSamePrice(a3)))
            {
                if (a2.IsSamePrice(a1))
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("OK");
            }
            Console.ReadLine();
        }
    }
}
