using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            string name;
            int numOfPeople = -1, highestPrice = 0;

            while (numOfPeople != 0)
            {
                Console.WriteLine("How many family members?");
                numOfPeople = int.Parse(Console.ReadLine());
                if (numOfPeople != 0)
                {
                    Console.WriteLine("What is the family name?");
                    name = Console.ReadLine();
                    counter += numOfPeople;
                    Family fam = new Family(numOfPeople, name);

                    Console.WriteLine("The family " + name + " will have to pay: " + fam.CalcPrice());
                    if (fam.CalcPrice() > highestPrice)
                    {
                        highestPrice = fam.CalcPrice();
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine("There are " + counter + " people that are participating in this trip.");
            Console.WriteLine("The highest price a family has to pay is: " + highestPrice + "$");


            Console.ReadLine();
        }
    }
}
