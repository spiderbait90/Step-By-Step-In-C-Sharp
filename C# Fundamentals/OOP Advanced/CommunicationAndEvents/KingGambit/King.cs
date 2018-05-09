using System;
using System.Collections.Generic;
using System.Text;

public class King
{
    public King(string name)
    {
        Name = name;
    }
    public string Name { get; }

    public override string ToString()
    {
        return $"King {Name} is under attack!";
    }
}

