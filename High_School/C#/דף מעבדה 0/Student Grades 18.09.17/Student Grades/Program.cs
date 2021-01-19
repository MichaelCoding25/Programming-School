using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            float gradeA, gradeB;
            double average;

            Console.WriteLine("What is your first grade?");
            gradeA = float.Parse(Console.ReadLine());
            Console.WriteLine("Whats is your second grade?");
            gradeB = float.Parse(Console.ReadLine());
            average = (gradeA+gradeB)/2;
            Console.WriteLine("The average grade is: " + average);
            Console.ReadLine();
        }
    }
}
