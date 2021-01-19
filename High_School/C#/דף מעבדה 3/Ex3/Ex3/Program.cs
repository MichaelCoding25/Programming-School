using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            char user;
            Console.WriteLine("Please press a key on your keyboard and then press Enter:");
            user = char.Parse(Console.ReadLine());
            if (user >= 48 && user <= 57)
                Console.WriteLine("You entered a number");
            else if (user >= 65 && user <= 90)
                Console.WriteLine("You entered a capital letter");
            else if (user >= 97 && user <= 122)
                Console.WriteLine("You entered a letter");
            else
                Console.WriteLine("You entered something else");
            Console.ReadLine();
        }
    }
}
