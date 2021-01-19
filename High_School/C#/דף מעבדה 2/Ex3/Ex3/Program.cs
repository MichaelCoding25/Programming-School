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
            int count, deathAge, birthYear;
            string name;
            count = 0;

            Console.WriteLine("What is the full name of Gandhi?");
            name = Console.ReadLine();
            if (name == "Mohandas Karamchand Gandhi")
            {
                Console.WriteLine("Your answer was correct.");
                count += 1;
            }
            else
            {
                Console.WriteLine("Your answer was incorrect.");
            }

            Console.WriteLine("How old was Gandhi when he died? ");
            deathAge = int.Parse(Console.ReadLine());
            if (deathAge == 78)
            {
                Console.WriteLine("Your answer was correct.");
                count += 1;
            }
            else
            {
                Console.WriteLine("Your answer was incorrect.");
            }

            Console.WriteLine("What year was Gandhi born in?");
            birthYear = int.Parse(Console.ReadLine());
            if (birthYear == 1869)
            {
                Console.WriteLine("Your answer is correct.");
                count += 1;
            }
            else
            {
                Console.WriteLine("Your answer is incorrect.");
            }
            Console.WriteLine();

            if(count == 3)
            {
                Console.WriteLine("You answered all 3 questions right");
            }

            else
            {
                Console.WriteLine("You answered " + count + " questions right.");
            }
            Console.ReadLine();    
        }
    }
}
