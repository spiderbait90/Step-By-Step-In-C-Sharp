using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var songs = new List<Song>();

        for (int i = 0; i < n; i++)
        {
            try
            {
                var input = Console.ReadLine().Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

                var artistName = input[0];
                var songName = input[1];
                var lenght = input[2].Split(':');
                int mm;
                int ss;

                try
                {
                    mm = int.Parse(lenght[0]);
                    ss = int.Parse(lenght[1]);
                }
                catch (Exception)
                {
                    throw new ArgumentException("Invalid song length.");
                }

                var song = new Song(artistName, songName, mm, ss);

                songs.Add(song);
                Console.WriteLine("Song added.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        var sumMm = songs.Sum(x => x.SongLenghtMinutes);
        var sumSs = songs.Sum(x => x.SongLenghtSeconds) + sumMm * 60;

        Console.WriteLine($"Songs added: {songs.Count}");

        Console.WriteLine($"Playlist length: {(sumSs / 60) / 60}h {(sumSs / 60) % 60}m {sumSs % 60}s");
    }
}

