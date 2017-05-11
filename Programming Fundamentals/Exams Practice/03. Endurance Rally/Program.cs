using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Endurance_Rally
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split(' ')
                .ToList();

            var zones = Console.ReadLine().Split(' ')
                .Select(double.Parse).ToList();

            var checkPoint = Console.ReadLine().Split(' ')
                .Select(long.Parse).ToList();
            var list = new List<string>();
            foreach (var name in names)
            {
                double fuel = name.First();
                double reached = 0;
                for (int i = 0; i < zones.Count; i++)
                {
                    var check = false;
                    
                    for (int i2 = 0; i2 < checkPoint.Count; i2++)
                    {
                        if (i == checkPoint[i2])
                            check = true;
                    }
                    if (check)
                        fuel += zones[i];
                    else if (!check)
                        fuel -= zones[i];
                    if (fuel < 1)
                    {
                        reached = i;
                        break;
                    }
                }
                if (fuel < 1)
                    list.Add($"{name} - reached {reached}");
                else
                    list.Add($"{name} - fuel left {fuel:f2}");
            }

            Console.WriteLine(string.Join(Environment.NewLine,list));
        }
    }
}
