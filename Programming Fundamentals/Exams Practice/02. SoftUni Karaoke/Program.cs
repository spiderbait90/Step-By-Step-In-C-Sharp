using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.SoftUni_Karaoke
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine()
                .Split(new[] { ' ', ',' },
                StringSplitOptions.RemoveEmptyEntries).ToList();

            var songs = Console.ReadLine().Split(new[] { ',' },
                StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToList();

            var data = Console.ReadLine();

            var result = new Dictionary<string, List<string>>();
            while (data != "dawn")
            {
                var split = data.Split(',').Select(x => x.Trim())
                    .ToList();
                var name = split[0];
                var song = split[1];
                var award = split[2];

                if (names.Contains(name) && songs.Contains(song))
                {
                    if (!result.ContainsKey(name))
                        result[name] = new List<string>();

                    if (!result[name].Contains(award))
                        result[name].Add(award);

                }
                data = Console.ReadLine();
            }

            if (result.Count!=0)
            {
                foreach (var name in result
                    .OrderByDescending(x => x.Value.Count)
                    .ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{name.Key}: {name.Value.Count} awards");
                    foreach (var award in name.Value.OrderBy(x=>x))
                    {
                        Console.WriteLine($"--{award}");
                    }
                }
            }
            else
                Console.WriteLine("No awards");
            
        }
    }
}
