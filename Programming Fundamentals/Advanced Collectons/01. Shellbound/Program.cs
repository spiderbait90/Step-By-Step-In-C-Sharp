using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Shellbound
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var data = new Dictionary<string, HashSet<int>>();

            while (input != "Aggregate")
            {
                var town0Shell1 = input.Split();
                string town = town0Shell1[0]; var size = int.Parse(town0Shell1[1]);
                if (!data.ContainsKey(town))
                {
                    data[town] = new HashSet<int>();
                }
                data[town].Add(size);
                input = Console.ReadLine();
            }
            foreach (var town in data)
            {
                Console.WriteLine($"{town.Key} -> " +
                    $"{string.Join(", ", town.Value)} " +
                    $"({town.Value.Sum() - (int)(town.Value.Average())})");
            }
        }
    }
}
