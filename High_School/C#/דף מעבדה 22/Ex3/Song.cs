using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    public class Song
    {
        private string nameOfSong;
        private string nameOfSinger;
        private int songLength;

        public Song()
        {
            nameOfSong = "Unkown";
            nameOfSinger = "Unknown";
            songLength = 0;
        }
        public Song(string nSong, string nSinger, int sLenght)
        {
            nameOfSong = nSong;
            nameOfSinger = nSinger;
            songLength = sLenght;
        }

        public void SetSongName(string NewNameSong)
        {
            nameOfSong = NewNameSong;
        }
        public void SetSingerName(string NewNameSinger)
        {
            nameOfSinger = NewNameSinger;
        }
        public void SetSongLength(int NewLength)
        {
            songLength = NewLength;
        }
        public string GetSongName()
        {
            return nameOfSong;
        }
        public string GetSingerName()
        {
            return nameOfSinger;
        }
        public int GetSongLength()
        {
            return songLength;
        }

        public void AddSeconds(int seconds)
        {
            songLength += seconds;
        }
        public void SubtractSeconds(int seconds)
        {
            songLength -= seconds;
        }
        public string SongLengthType()
        {
            if (songLength > 240)
            {
                return "Long";
            }
            else if (songLength < 120)
            {
                return "Short";
            }
            else
            {
                return "Average";
            }
        }
        public void GetDetails()
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("      Song Deatils:");
            Console.WriteLine("__________________________");
            Console.WriteLine("Name of the song: " + nameOfSong);
            Console.WriteLine("Name of the singer: " + nameOfSinger);
            Console.WriteLine("Lenght of song: " + songLength);
            Console.WriteLine("--------------------------");
        }
    }
}
