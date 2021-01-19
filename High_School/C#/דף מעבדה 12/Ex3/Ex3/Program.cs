using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numStudents;
            Console.WriteLine("How many students in class?");
            numStudents = int.Parse(Console.ReadLine());
            int[] grade1 = new int[numStudents];
            int[] grade2 = new int[numStudents];
            int[] finalGrade = new int[numStudents];
            Console.WriteLine("The first bunch of grades are:");
            for (int i = 0; i < grade1.Length; i++)
            {
                grade1[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The second bunch of grades are:");
            for (int i = 0; i < grade1.Length; i++)
            {
                grade2[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < grade1.Length; i++)
            {
                finalGrade[i] = Math.Max(grade1[i], grade2[i]);
            }
            Console.WriteLine("The final grades are:");
            for (int i = 0; i < grade2.Length; i++)
            {
                Console.Write(finalGrade[i] + " ");
            }

            Console.ReadLine();
        }
    }
}
