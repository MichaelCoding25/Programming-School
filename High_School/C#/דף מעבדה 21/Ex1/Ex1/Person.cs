using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    public class Person
    {
        private string name;
        private int age = 0;
        private double weight = 2.5;

        public Person(string n)
        {
            name = n;
        }

        public void SetName(string newName)
        {
            name = newName;
        }

        public void Birthday()
        {
            age += 1;
            Console.WriteLine("Happy birthday {0}! You're now {1} years old", name, age);
            Console.WriteLine();
        }

        public void Eat(double foodWeight)
        {
            weight += foodWeight;
            Console.WriteLine(name + " now weighs " + weight + " kilograms.");
            Console.WriteLine();
        }

        public void Exercise(int minutes)
        {
            weight -= 0.1 * minutes;
            Console.WriteLine(name + ", you burned " + (0.1 * minutes) + " kilograms.");
            Console.WriteLine(name + " you now weight " + weight + " kilograms.");
            Console.WriteLine();
        }

        public void PrintDetails()
        {
            Console.WriteLine(" * Details * ");
            Console.WriteLine("==============");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Weight: " + weight);
            Console.WriteLine("==============");
            Console.WriteLine();
        }
    }
}
