using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Program
    {
        public static double AverageSongLength(Song[] songList)
        {
            double sum = 0, avg;
            for (int i = 0; i < songList.Length; i++)
            {
                sum += songList[i].GetSongLength(); 
            }
            avg = sum / songList.Length;
            return avg;
        }
        public static int TheLongestSong(Song[] songList)
        {
            int longestIndx = 0, longestSong = 0;
            for (int i = 0; i < songList.Length; i++)
            {
                if (songList[i].GetSongLength() > longestSong)
                {
                    longestIndx = i;
                    longestSong = songList[i].GetSongLength();
                }
            }
            return longestIndx;
        }
        public static int NumberOfShortSongs(Song[] songList)
        {
            int counter = 0;
            for (int i = 0; i < songList.Length; i++)
            {
                if (songList[i].SongLengthType() == "Short")
                {
                    counter++;
                }
            }
            return counter;
        }
        static void Main(string[] args)
        {
            string name, perf;
            int time;
            double sum = 0;


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

            Console.WriteLine("A new song list:");

            Song[] songs2 = new Song[10];
            for (int i = 0; i < songs2.Length; i++)
            {
                Console.WriteLine("Enter song Details: (Name of song, Name of singer, Song length)");
                name = Console.ReadLine();
                perf = Console.ReadLine();
                time = int.Parse(Console.ReadLine());

                songs[i] = new Song(name, perf, time);
            }
            Console.WriteLine();
            Console.WriteLine("The average song length is " + AverageSongLength(songs2) + " seconds.");
            Console.WriteLine("The longest song is: " + songs2[TheLongestSong(songs2)]);
            Console.WriteLine("The number of short songs is: " + NumberOfShortSongs(songs2));


            Console.ReadLine();
        }
    }
}
