using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            double age1, age2, difference, lowestAge;
            Console.WriteLine("Enter the age of the first student:");
            age1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the age of the second student:");
            age2 = double.Parse(Console.ReadLine());
            difference = Math.Abs(age1 - age2);
            lowestAge = Math.Min(age1, age2);
            Console.WriteLine("The difference between the ages is: " + difference + ", and the lowest age is: " + lowestAge);
            Console.ReadLine();
        }
    }
}
