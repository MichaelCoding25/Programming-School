using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page1_Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int minUser, min, hours;
            Console.WriteLine("Please write the number of minutes:");
            minUser = int.Parse(Console.ReadLine());
            hours = minUser / 60;
            min = minUser % 60;
            Console.WriteLine(hours + " Hours, " + min + " Minutes");

            Console.ReadLine();
        }
    }
}
