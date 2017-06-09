using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            var junkItems = new SortedDictionary<string, int>();
            var qualityItems = new SortedDictionary<string, int>();
            qualityItems["fragments"] = new int();
            qualityItems["shards"] = new int();
            qualityItems["motes"] = new int();

            while (true)
            {
                var input = Console.ReadLine().ToLower().Split();

                for (int i = 0; i < input.Length; i += 2)
                {
                    if (input[i + 1] == "shards" ||
                        input[i + 1] == "fragments" ||
                        input[i + 1] == "motes")
                    {                        
                        qualityItems[input[i + 1]] += int.Parse(input[i]);
                        if (qualityItems[input[i + 1]] >= 250)
                            break;
                    }
                    else
                    {
                        if (!junkItems.ContainsKey(input[i + 1]))
                            junkItems[input[i + 1]] = new int();
                        junkItems[input[i + 1]] += int.Parse(input[i]);
                    }
                }
                foreach (var item in qualityItems)
                {
                    if (item.Value >= 250)
                    {
                        qualityItems[item.Key] -= 250;
                        if (item.Key == "shards")
                            Console.WriteLine("Shadowmourne obtained!");
                        else if (item.Key == "fragments")
                            Console.WriteLine("Valanyr obtained!");
                        else
                            Console.WriteLine("Dragonwrath obtained!");
                        goto Out;
                    }
                }
            }
        Out:
            foreach (var item in qualityItems
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            foreach (var item in junkItems.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
