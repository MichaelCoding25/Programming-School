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
            Person human1 = new Person("Adi");
            Person human2 = new Person("David");

            human1.Birthday();
            human1.Eat(0.5);
            human1.Eat(1.7);

            human2.Birthday();
            human2.Eat(0.3);

            human1.Birthday();
            human1.Eat(2.2);
            human1.Exercise(5);

            human2.Birthday();
            human2.Eat(1.1);
            human2.Exercise(20);

            human1.PrintDetails();
            human2.PrintDetails();



            Console.ReadLine();
        }
    }
}
