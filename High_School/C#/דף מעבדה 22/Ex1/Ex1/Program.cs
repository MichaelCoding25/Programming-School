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
            Song song1 = new Song();
            Song song2 = new Song("Over The Rainbow", "Disney", 250);
            song1.AddSeconds(20);
            song1.GetDetails();
            Console.WriteLine();
            Console.WriteLine("The length of song1 is: " + song1.GetSongLength() + " seconds");
            Console.WriteLine();
            if (song1.GetSongLength() > song2.GetSongLength())
            {
                Console.WriteLine("The song " + song1.GetSongName() + " is longer.");
            }
            else if (song2.GetSongLength() > song1.GetSongLength())
            {
                Console.WriteLine("The song " + song2.GetSongName() + " is longer.");
            }
            else
            {
                Console.WriteLine("Both songs are equally long.");
              
            }

            Console.ReadLine();
        }
    }
}
