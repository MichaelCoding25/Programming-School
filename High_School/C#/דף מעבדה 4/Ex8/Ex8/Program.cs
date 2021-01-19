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
            Random random = new Random();
            int month = random.Next(1, 13);
            Console.WriteLine("The random month is: " + month);
            Console.WriteLine("");
            int cube1 = random.Next(1, 7);
            Console.WriteLine("The random cube is: " + cube1);
            Console.WriteLine("");
            int cube2 = random.Next(1, 7);
            Console.WriteLine("Another random cube is: " + cube2);
            Console.ReadLine();
        }
    }
}
