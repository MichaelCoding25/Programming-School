using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            double avg;
            int grade, moreThen = 0, lessThen = 0;
            Console.WriteLine("Please enter the grade average:");
            avg = double.Parse(Console.ReadLine());
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine("Please enter your grade:");
                grade = int.Parse(Console.ReadLine());
                if (grade > avg)
                {
                    moreThen += 1;
                }
                else if (grade < avg)
                {
                    lessThen += 1;
                }
            }
            Console.WriteLine("");
            Console.WriteLine("There are " + moreThen + " students which have a grade higher than average.");
            Console.WriteLine("There are " + lessThen + " students which have a grade lower than average.");

                Console.ReadLine();
        }
    }
}
