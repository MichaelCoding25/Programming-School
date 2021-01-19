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
            int[] grades;
            int numOfStudents;

            Console.WriteLine("Enter how many students:");
            numOfStudents = int.Parse(Console.ReadLine());

            grades = GetGrades(numOfStudents); // A

            UpdateGradesWithBonus(grades); // B

            Console.WriteLine("The grades after the bonus:");
            PrintArray(grades); // C

            Console.ReadLine();
        }
        static int[] GetGrades(int numOfStudents)
        {
            int[] grades = new int[numOfStudents];
            for (int i = 0; i < grades.Length; i++)
            {
                Console.WriteLine("Enter the grade of student number " + (i + 1));
                grades[i] = int.Parse(Console.ReadLine());
            }
            return grades;
        }
        static void UpdateGradesWithBonus(int[] grades)
        {
            int bonus = 10;
            for (int i = 0; i < grades.Length; i++)
            {
                grades[i] = grades[i] + bonus;
                if (grades[i] > 100)
                {
                    grades[i] = 100;
                }
            }
            
        }
        static void PrintArray(int[] grades)
        {
            for (int i = 0; i < grades.Length; i++)
            {
                Console.Write(grades[i] + " ");
            }
        }
    } 
}
