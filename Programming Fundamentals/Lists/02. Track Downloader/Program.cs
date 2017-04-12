using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Track_Downloader
{
    class Program
    {
        static void Main(string[] args)
        {
            var album = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            bool check = false;
            var songs = new List<string>();
            var song = Console.ReadLine();
            do

            {
                for (int i = 0; i < album.Count; i++)
                {
                    if (song.Contains(album[i]))
                    {
                        check = true;
                        break;
                    }
                }
                if (check == true)
                {
                    check = false;                    
                }
                else
                    songs.Add(song);
                song = Console.ReadLine();
            } while (song!="end");
            songs.Sort();
            Console.WriteLine(string.Join(Environment.NewLine,songs));
            
        }
    }
}
