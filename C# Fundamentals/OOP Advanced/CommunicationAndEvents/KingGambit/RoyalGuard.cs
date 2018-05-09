using System;
using System.Collections.Generic;
using System.Text;


public class RoyalGuard
{
    public RoyalGuard(string name)
    {
        Name = name;
    }
    public string Name { get; }

    public override string ToString()
    {
        return $"Royal Guard {Name} is defending!";
    }
}
