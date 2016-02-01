/*
 * Copyright (C) Kimmo Oinonen
 *
 * This file is part of homework project in Object-Oriented
 * and GUI Programming class in JAMK.
 *
 * Created: 1.2.2016
 * Author: Kimmo Oinonen
 */
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

        private List<Song> songs;

        public CD()
        {
            songs = new List<Song>();
        }

        public void AddSong(Song song)
        {
            songs.Add(song);
        }

        public void PrintCollection()
        {
            Console.WriteLine("Songs:");
            foreach (Song song in songs)
            {
                Console.WriteLine(song.ToString());
            }
        }
        public override string ToString()
        {
            return "Album name: " + CdName + " Artist: " + Artist;
        }
    }
}
