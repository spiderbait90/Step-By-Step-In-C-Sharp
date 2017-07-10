using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            var pokemons = new Dictionary<string, Dictionary<string, long>>();
            var count = 10;
            while (true)
            {
                var input = Console.ReadLine()
                    .Split(new[] { '-', '>', ' ' },
                    StringSplitOptions.RemoveEmptyEntries);
                if (input[0] == "wubbalubbadubdub" &&
                    input.Length == 1)
                    break;
                if (input.Length == 1)
                {
                    if (pokemons.ContainsKey(input[0]))
                    {
                        Console.WriteLine($"# {input[0]}");
                        foreach (var item in pokemons[input[0]])
                        {
                            Console.WriteLine($"{new string(item.Key.Skip(2).ToArray())} <-> {item.Value}");
                        }
                    }
                }
                else
                {
                    var name = input[0];
                    var type = input[1];
                    var index = long.Parse(input[2]);

                    if (!pokemons.ContainsKey(name))
                        pokemons[name] = new Dictionary<string, long>();
                    pokemons[name].Add($"{count}" + type, index);
                    count++;
                }
                if (count > 98)
                    count = 10;
            }
            foreach (var pokemon in pokemons)
            {
                Console.WriteLine($"# {pokemon.Key}");
                foreach (var type in pokemon.Value
                    .OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"{new string(type.Key.Skip(2).ToArray())} <-> {type.Value}");
                }
            }
        }
    }
}
