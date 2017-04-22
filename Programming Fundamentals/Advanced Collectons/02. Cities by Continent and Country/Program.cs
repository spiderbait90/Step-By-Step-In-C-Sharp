using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<string, Dictionary<string, List<string>>>();
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ');
                var continent = input[0]; var country = input[1];
                var town = input[2];

                if (!data.ContainsKey(continent))
                {
                    data[continent] = new Dictionary<string, List<string>>();
                }
                if (!data[continent].ContainsKey(country))
                {
                    data[continent][country] = new List<string>();
                }
                data[continent][country].Add(town);
            }
            foreach (var continent in data)
            {
                Console.WriteLine($"{continent.Key}:");
                foreach (var country in continent.Value)
                {
                    Console.WriteLine($"  {country.Key} -> " +
                        $"{string.Join(", ", country.Value)}");
                }
            }
        }
    }
}
