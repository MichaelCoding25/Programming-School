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
            string nameCat, kindCat;
            bool waterCat, meowCat;
            Cat cat1 = new Cat("Mizi", "Siami", true, false);
            Cat cat2 = new Cat("Bob", "Street", false, true);

            Console.WriteLine("For cat1:");
            Console.WriteLine(cat1.GetDetails());
            Console.WriteLine("My special meow is: " + cat1.Meow());
            Console.WriteLine("I am thirsty: " + cat1.IsThirsty());
            Console.WriteLine();
            Console.WriteLine("For cat2:");
            Console.WriteLine(cat2.GetDetails());
            Console.WriteLine("My special meow is: " + cat2.Meow());
            Console.WriteLine("I am thirsty: " + cat2.IsThirsty());
            Console.WriteLine();
            Console.WriteLine("For the 3rd cat: What's his name?");
            nameCat = Console.ReadLine();
            Console.WriteLine("What kind is the cat?");
            kindCat = Console.ReadLine();
            Console.WriteLine("Does the cat like water?");
            waterCat = bool.Parse(Console.ReadLine());
            Console.WriteLine("Does the cat like to meow?");
            meowCat = bool.Parse(Console.ReadLine());
            Cat cat3 = new Cat(nameCat, kindCat, waterCat, meowCat);
            Console.WriteLine();
            Console.WriteLine("For cat3:");
            Console.WriteLine(cat3.GetDetails());
            Console.WriteLine("My special meow is: " + cat3.Meow());
            Console.WriteLine("I am thirsty: " + cat3.IsThirsty());
            Console.WriteLine();
            Cat cat4 = new Cat("Donkey", "Dumb", true, true);
            Console.WriteLine("For cat4:");
            Console.WriteLine(cat3.GetDetails());
            Console.WriteLine("My special meow is: " + cat4.Meow());
            Console.WriteLine("I am thirsty: " + cat4.IsThirsty());
            Console.WriteLine();
            cat4.DrinkWater();
            if (cat4.IsThirsty() == true)
            {
                Console.WriteLine("Cat4 is thirsty.");
            }
            else
            {
                Console.WriteLine("Cat4 isn't thirsty.");
            }
            Console.ReadLine();
        }
    }
}
