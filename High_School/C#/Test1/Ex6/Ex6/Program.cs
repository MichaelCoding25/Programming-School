using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            City[] cities = new City[248];
            string cityName;
            int cityPopul, citySchools, dontCounter = 0;

            for (int i = 0; i < cities.Length; i++)
            {
                Console.WriteLine("City number " + (i+1) + ":");
                Console.WriteLine("What is the name of the city?");
                cityName = Console.ReadLine();
                Console.WriteLine("How many people live in this city?");
                cityPopul = int.Parse(Console.ReadLine());
                Console.WriteLine("How many schools are in this city?");
                citySchools = int.Parse(Console.ReadLine());

                cities[i] = new City(cityName, cityPopul, citySchools);
                Console.WriteLine();
            }

            for (int i = 0; i < cities.Length; i++)
            {
                if (cities[i].IsFit())
                {
                    Console.WriteLine("The city " + cities[i].GetName() + " is fit for the survey.");
                }
                else
                {
                    Console.WriteLine("The city " + cities[i].GetName() + " isn't fit for the survey.");
                    dontCounter++;
                }
            }
            Console.WriteLine();
            Console.WriteLine(dontCounter + " cities aren't fit for the survey.");



            Console.ReadLine();
        }
    }
}
