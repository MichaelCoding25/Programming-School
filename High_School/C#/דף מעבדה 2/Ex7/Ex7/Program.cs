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
            int gradeCSharp, gradeAlgorithmic, programDesign;

            Console.WriteLine("Please enter your C# grade:");
            gradeCSharp = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your Algorthmic grade:");
            gradeAlgorithmic = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your Program Design Grade:");
            programDesign = int.Parse(Console.ReadLine());

            if (((gradeAlgorithmic > 79) && (gradeCSharp > 79)) || ((gradeAlgorithmic > 79) && (programDesign > 79)) || ((gradeCSharp > 79) && (programDesign > 79))) 
            {
                Console.WriteLine("You passed, you will continue into next year!");
            }
            else
            {
                Console.WriteLine("You have not passed, and you won't continue into grade B.");
            }
            Console.ReadLine();
        }
        
    }
}
