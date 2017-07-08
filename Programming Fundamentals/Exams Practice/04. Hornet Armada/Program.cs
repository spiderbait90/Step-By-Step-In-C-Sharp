using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Hornet_Armada
{
    public class Legion
    {
        public long LastActivity { get; set; }
        public string Name { get; set; }
        public Dictionary<string, long> Soldiers { get; set; }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            var legions = new Dictionary<string, Legion>();

            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine()
                    .Split(new[] { '=', ' ', '-', '>', ':' }
                    , StringSplitOptions.RemoveEmptyEntries);

                var curLegion = new Legion();
                curLegion.Soldiers = new Dictionary<string, long>();
                curLegion.LastActivity = long.Parse(line[0]);
                curLegion.Name = line[1];
                curLegion.Soldiers.Add(line[2], long.Parse(line[3]));

                if (!legions.ContainsKey(curLegion.Name))
                    legions[curLegion.Name] = curLegion;
                else
                {
                    if (legions[curLegion.Name].LastActivity < curLegion.LastActivity)
                        legions[curLegion.Name].LastActivity = curLegion.LastActivity;
                    if (legions[curLegion.Name].Soldiers.ContainsKey(line[2]))
                        legions[curLegion.Name].Soldiers[line[2]] += long.Parse(line[3]);
                    else
                        legions[curLegion.Name].Soldiers.Add(line[2], long.Parse(line[3]));
                }
            }
            var command = Console.ReadLine().Split('\\');

            if (command.Length == 2)
            {
                var soldType = command[1];
                var activity = long.Parse(command[0]);
                foreach (var legion in legions
                    .Where(x => x.Value.LastActivity < activity)
                    .Where(x => x.Value.Soldiers.ContainsKey(soldType))
                    .OrderByDescending(x => x.Value.Soldiers[soldType]))
                {
                    Console.WriteLine($"{legion.Key} -> {legion.Value.Soldiers[soldType]}");
                }
            }
            else
            {
                var soldType = command[0];
                foreach (var legion in legions
                    .Where(x => x.Value.Soldiers.ContainsKey(soldType))
                    .OrderByDescending(x => x.Value.LastActivity))
                {
                    Console.WriteLine($"{legion.Value.LastActivity} : {legion.Key}");
                }
            }
        }
    }
}