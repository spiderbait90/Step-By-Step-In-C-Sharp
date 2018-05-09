using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Trainer
{
    public Trainer()
    {
        Pokemons = new List<Pokemon>();
    }
    public Trainer(string name, long badges, List<Pokemon> pokemons)
    {
        Name = name;
        Badges = badges;
        Pokemons = pokemons;
    }
    public string Name { get; set; }

    public long Badges { get; set; }

    public List<Pokemon> Pokemons { get; set; }
}

