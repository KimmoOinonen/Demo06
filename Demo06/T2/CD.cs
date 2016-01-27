using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class CD
    {
        public string CdName { get; set; }
        public string Artist { get; set; }

        private List<CD> songs;

        public CD()
        {
            songs = new List<CD>();
        }

        public void AddSong(CD song)
        {
            songs.Add(song);
        }

        public void PrintSongs()
        {
            Console.WriteLine("Songs:");
            foreach (CD song in songs)
            {
                Console.WriteLine(song.ToString());
            }
        }
        public override string ToString()
        {
            return "Name: " + CdName + " Artist: " + Artist;
        }
    }
}
