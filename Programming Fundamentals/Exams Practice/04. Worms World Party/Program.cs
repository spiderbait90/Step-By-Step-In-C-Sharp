using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Worms_World_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<string, Dictionary<string, long>>();
            var names = new List<string>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "quit")
                    break;
                var line = input.Split(new[] { '-', '>' },
                    StringSplitOptions.RemoveEmptyEntries);

                var worm = line[0].Trim();
                var team = line[1].Trim();
                var score = long.Parse(line[2]);

                if (names.Contains(worm))
                {

                }
                else
                {
                    if (!data.ContainsKey(team))
                        data[team] = new Dictionary<string, long>();
                    data[team].Add(worm, score);
                    names.Add(worm);
                }

            }
            var count = 0;
            foreach (var team in data
                .OrderByDescending(x => x.Value.Values.Sum())
                .ThenByDescending(x => x.Value.Values.Average()))
            {
                count++;
                Console.WriteLine($"{count}. Team: {team.Key} - {team.Value.Values.Sum()}");
                foreach (var worm in team.Value
                    .OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"###{worm.Key} : {worm.Value}");
                }
            }
        }
    }
}
