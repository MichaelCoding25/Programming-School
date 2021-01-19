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
            int r, c;
            Console.WriteLine("Enter the number of rows:");
            r = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of colums:");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine();
            CreateMat(r, c);
            Console.ReadLine();
        }
        static void CreateMat(int rows, int columns)
        {
            int[,] mat = new int[rows, columns];
            for (int row = 0; row < rows; row++)
            {
                for (int column = 0; column < columns; column++)
                {
                    mat[row, column] = (row + 1) * 10 + column + 1;
                }
            }
            for (int index = 0; index < mat.GetLength(0); index++)
            {
                for (int index2 = 0; index2 < mat.GetLength(1); index2++)
                {
                    Console.Write(mat[index, index2].ToString() + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
