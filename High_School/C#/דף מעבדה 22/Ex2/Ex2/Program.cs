using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, perf;
            int time, sum = 0;
            
           
            Song[] songs = new Song[10];
            for (int i = 0; i < songs.Length; i++)
            {
                Console.WriteLine("Enter song Details: (Name of song, Name of singer, Song length)");
                name = Console.ReadLine();
                perf = Console.ReadLine();
                time = int.Parse(Console.ReadLine());

                songs[i] = new Song(name, perf, time);

                sum += time;
            }

            Console.WriteLine("The average length of the songs is: " + (sum / songs.Length));

            Console.ReadLine();
        }
    }
}
