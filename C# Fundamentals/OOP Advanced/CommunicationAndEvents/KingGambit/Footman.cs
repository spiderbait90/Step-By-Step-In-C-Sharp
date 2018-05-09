using System;
using System.Collections.Generic;
using System.Text;

public class Footman
{
    public Footman(string name)
    {
        Name = name;
    }
    public string Name { get; }

    public override string ToString()
    {
        return $"Footman {Name} is panicking!";
    }
}

