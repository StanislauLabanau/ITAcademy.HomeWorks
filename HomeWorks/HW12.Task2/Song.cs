using System;
using System.Collections.Generic;
using System.Text;

namespace HW12.Task2
{
    class Song
    {
        private string _title;
        private double _minutes;
        private string _author;
        private int _albumYear;
        private SongGenre _songGenre;

        public Song(string title, double minutes, string author, int albumYear, SongGenre songGenre)
        {
            _title = title;
            _minutes = minutes;
            _author = author;
            _albumYear = albumYear;
            _songGenre = songGenre;
        }

        public static object GetSongData(Song song)
        {
            var SongData = new
            {
                Title = song._title,
                Minutes = song._minutes,
                AlbumYear = song._albumYear,
                SongGenre = song._songGenre
            };
            return SongData;
        }
    }
}
