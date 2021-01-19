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
            int[,] grades = new int[8, 3] {
            {88, 90, 92},
            {78, 70, 94},
            {99, 90, 91},
            {88, 81, 70},
            {92, 92, 100},
            {80, 84, 76},
            {76, 82, 86},
            {85, 79, 94}
            };
            Console.WriteLine("Student 5 Avrg: " + StudentAvrg(grades, 4));
            Console.WriteLine("Exam 2 Avrg: " + ExamAvrg(grades, 1));
            Console.WriteLine("Max Grade: " + MaxGrade(grades));
            PrintMatrix(grades);

            Console.ReadLine();
        }
        static double StudentAvrg(int[,] grades, int student)
        {
            double avrg = 0;
            for (int test = 0; test < grades.GetLength(1); test++)
            {
                avrg += grades[student, test];
            }
            return avrg / grades.GetLength(1);
        }
        static double ExamAvrg(int[,] grades, int exam)
        {
            double avrg = 0;
            for (int student = 0; student < grades.GetLength(0); student++)
            {
                avrg += grades[student, exam];
            }
            return avrg / grades.GetLength(0);
        }
        static int MaxGrade(int[,] mat)
        {
            int max = mat[0, 0];
            for (int index1 = 0; index1 < mat.GetLength(0); index1++)
            {
                for (int index2 = 0; index2 < mat.GetLength(1); index2++)
                {
                    if (mat[index1, index2] > max)
                    {
                        max = mat[index1, index2];
                    }
                }
            }
            return (max);
        }
        static void PrintMatrix(int[,] mat)
        {
            Console.Write("  ");
            for (int index = 0; index < mat.GetLength(1); index++)
            {
                Console.Write("   {0}", index+1);
            }
            Console.WriteLine();
            for (int index = 0; index < mat.GetLength(1) * 4 + 2; index++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
            for (int index = 0; index < mat.GetLength(0); index++)
            {
                Console.Write("{0}: ", index + 1);
                for (int index2 = 0; index2 < mat.GetLength(1); index2++)
                {
                    Console.Write("{0,3} ", mat[index, index2].ToString());
                }
                Console.WriteLine();
            }
        }
    }
}
