using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            int monthDay, month;
            string year, wordMonth;
            Console.WriteLine("Please enter a date:");
            monthDay = int.Parse (Console.ReadLine());
            month = int.Parse(Console.ReadLine());
            year = Console.ReadLine();
            year = 20 + year;
            switch (month)
            {
                case 1:
                    wordMonth = "January";
                    break;
                case 2:
                    wordMonth = "Fabruary";
                    break;
                case 3:
                    wordMonth = "March";
                    break;
                case 4:
                    wordMonth = "April";
                    break;
                default:
                    wordMonth = "Other month";
                    break;        
            }
            Console.WriteLine(wordMonth + " " +monthDay + " " + year);

            Console.ReadLine();
        }
    }
}
