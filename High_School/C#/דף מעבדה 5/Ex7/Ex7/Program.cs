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
            int total = 0, grade, gradenum = 5;
            double avg;
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Please enter your grade:");
                grade = int.Parse(Console.ReadLine());
                total += grade;
            }
            avg = total / gradenum;
            Console.WriteLine("The average is " + avg);
            Console.ReadLine();
        }
    }
}
