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
            int grade = 0, average, counter = 0, total = 0;
            Console.WriteLine("Please enter your grade:");
            grade = int.Parse(Console.ReadLine());
            while (grade != 999)
            {
                total += grade;
                counter++;
                Console.WriteLine("Please enter your grade:");
                grade = int.Parse(Console.ReadLine());
                
            }
            average = total / counter;
            Console.WriteLine("The average is: " + average);
            Console.ReadLine();
        }
    }
}
