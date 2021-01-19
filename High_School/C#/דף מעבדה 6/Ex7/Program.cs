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
            int answer = 1945, input = 0;
            while (input != answer)
            {
                Console.WriteLine("What is the year World War 2 ended in?");
                input = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Good Job!");

            Console.ReadLine();
        }
    }
}
