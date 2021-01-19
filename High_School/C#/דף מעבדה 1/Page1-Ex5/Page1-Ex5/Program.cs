using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page1_Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            int nails, box, nailsNoBox, fullBoxes;

            Console.WriteLine("How many nails can there be in a box of nails?");
            box = int.Parse(Console.ReadLine());
            Console.WriteLine("How many nails are there?");
            nails = int.Parse(Console.ReadLine());
            fullBoxes = nails / box;
            nailsNoBox = nails % box;
            Console.WriteLine("The number of boxes that are needed is: " + fullBoxes + ", and " + nailsNoBox + " nails will be without a box.");

            Console.ReadLine();
        }
    }
}
