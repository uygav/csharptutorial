﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Song
    {

        public string title;
        public string artist;
        public int duration;
        static public int songCount = 0;


        public Song(string aTitle , string aArtist , int aDuration) {
            title = aTitle;
            artist = aArtist;
            duration = aDuration;
            songCount++;
        }

    }
}
