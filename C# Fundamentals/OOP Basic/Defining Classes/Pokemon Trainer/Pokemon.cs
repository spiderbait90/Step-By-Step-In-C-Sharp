using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Pokemon
{
    public Pokemon()
    {
        
    }

    public Pokemon(string name, string element, long health)
    {
        Name = name;
        Element = element;
        Health = health;
    }

    public string Name { get; set; }

    public string Element { get; set; }

    public long Health { get; set; }
}

