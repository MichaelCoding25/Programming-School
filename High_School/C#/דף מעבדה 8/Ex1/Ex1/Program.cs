using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int rand, counter = 0, guess = 0;
            Random rnd = new Random();
            rand = rnd.Next(1, 21);
            Console.WriteLine("Hello user!");
            Console.WriteLine("I am thinking of a number between 1 and 20.");
            while (guess != rand && counter < 6)
            {
                Console.WriteLine("Take a guess");
                guess = int.Parse(Console.ReadLine());
                counter++;
                if (guess > rand)
                    Console.WriteLine("Your guess is too high");
                else if (guess < rand)
                    Console.WriteLine("Your guess is too low");
            }
            if (counter < 6)
                Console.WriteLine("Good job, you guessed my number in {0} tries.", guess);
            else
                Console.WriteLine("You failed to guess my number in 5 tries.");
            Console.ReadLine();
        }
    }
}
