using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Rebel : IBuyer,IRebel
{
    public Rebel(string name, string age, string group)
    {
        Name = name;
        Age = age;
        Group = group;
    }

    public string Name { get; set; }
    public string Age { get; set; }
    public int Food { get; set; }
    public string Group { get; set; }
    public void BuyFood()
    {
        Food += 5;
    }
    
}

