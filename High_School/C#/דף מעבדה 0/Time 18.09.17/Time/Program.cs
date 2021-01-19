using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time
{
    class Program
    {
        static void Main(string[] args)
        {
            int years, months, days, sum;
            Console.WriteLine("Enter the number of years:");
            years = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of months:");
            months = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of days:");
            days = int.Parse(Console.ReadLine());
            sum = days + 30 * months + 365 * years;
            Console.WriteLine(years + " years, " + months + " months and " + days + " days, are: " + sum + " days.");
            Console.ReadLine();
        }
    }
}
