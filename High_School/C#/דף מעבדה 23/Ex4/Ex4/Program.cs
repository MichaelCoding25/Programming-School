using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Building[] builds = new Building[4];
            string address;
            int numOfAps;
            int counter = 0;


            for (int i = 0; i < builds.Length; i++)
            {
                Console.WriteLine("Enter what's the address for building number " + (i + 1) + ": ");
                address = Console.ReadLine();
                Console.WriteLine("Please enter the number of apartments in this building:");
                numOfAps = int.Parse(Console.ReadLine());
                builds[i] = new Building(address, numOfAps);
                if (builds[i].houseCommity())
                {
                    counter++;
                }
                Console.WriteLine();
            }
            Console.WriteLine("There are " + counter + " buildings which need a house commity.");
            Console.ReadLine();
        }
    }
}
