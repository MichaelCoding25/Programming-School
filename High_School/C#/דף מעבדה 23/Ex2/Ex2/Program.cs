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
            TvProgram tv1 = new TvProgram(712465, 4, false);
            TvProgram tv2 = new TvProgram(731641, 3, true);
            TvProgram tv3 = new TvProgram(123543, 6, true);

            TvWeek week1 = new TvWeek();
            week1.AddProgram(tv1);
            week1.AddProgram(tv2);
            week1.AddProgram(tv3);

            Console.WriteLine("There are " + week1.GetSportsPrograms() + " sports programs this week.");


            Console.ReadLine();
        }
    }
}
