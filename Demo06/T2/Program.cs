using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class Program
    {
        static void Main(string[] args)
        {
            CD cd = new CD { CdName = "Endless Forms", Artist = "Nightwish" };

            Song song1 = new Song { SongName = "Shudder", SongLenght = "6:29" };
            Song song2 = new Song { SongName = "Weak Fantasy", SongLenght = "5:23" };
            Song song3 = new Song { SongName = "Elan", SongLenght = "4:45" };

            cd.AddSong(song1);
            cd.AddSong(song2);
            cd.AddSong(song3);

            cd.PrintSongs();

        }
    }
}
