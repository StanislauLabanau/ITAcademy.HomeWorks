using Newtonsoft.Json;
using System;

namespace HW12.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Song song = new Song("Numb", 3.35, "Linkin Park", 2000, SongGenre.Numetal);

            string json = JsonConvert.SerializeObject(Song.GetSongData(song));

            Console.WriteLine(json);
            Console.ReadKey();
        }
    }
}
