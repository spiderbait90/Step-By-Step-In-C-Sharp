using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    public static void Main(string[] args)
    {
        var trainers = new Dictionary<string, Trainer>();
        while (true)
        {
            var input = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (input[0] == "Tournament")
                break;

            var trainerName = input[0];
            var pokemonName = input[1];
            var pokemonElement = input[2];
            var pokemonHealth = long.Parse(input[3]);

            var pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

            if (!trainers.ContainsKey(trainerName))
            {
                trainers[trainerName] = new Trainer();
                trainers[trainerName].Name = trainerName;
            }

            trainers[trainerName].Pokemons.Add(pokemon);
        }

        while (true)
        {
            var element = Console.ReadLine();

            if (element == "End")
                break;

            foreach (var t in trainers.Values)
            {
                if (t.Pokemons.Any(x => x.Element == element))
                {
                    t.Badges += 1;

                    /*
                    foreach (var p in t.Pokemons)
                    {
                        if (p.Element == element)
                        {
                            t.Badges += 1;
                        }
                    }
                    */
                }
                else
                {
                    if (t.Pokemons.Any())
                    {
                        foreach (var p in t.Pokemons)
                        {
                            p.Health -= 10;

                            if (p.Health <= 0)
                            {
                                t.Pokemons.Remove(p);
                                break;
                            }
                        }
                    }
                }
            }
        }

        foreach (var t in trainers.Values
            .OrderByDescending(x => x.Badges))
        {
            Console.WriteLine($"{t.Name} {t.Badges} {t.Pokemons.Count}");
        }
    }
}

