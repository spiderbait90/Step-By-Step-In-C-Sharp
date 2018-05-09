using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Person
{
    public Person()
    {
        Parents = new List<Parent>();
        Pokemons = new List<Pokemon>();
        Children = new List<Child>();
    }

    public string Name { get; set; }

    public Company Company { get; set; }

    public Car Car { get; set; }

    public List<Parent> Parents { get; set; }

    public List<Pokemon> Pokemons { get; set; }

    public List<Child> Children { get; set; }

    
}

