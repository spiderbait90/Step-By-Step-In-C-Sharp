using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Citizen:IResident,IPerson
{
    public Citizen(string name, string age, string country)
    {
        Name = name;
        Age = age;
        Country = country;
    }
    public string Name { get; set; }

    public string Age { get; set; }

    public string Country { get; set; }

    string IResident.GetName()
    {
        return $"Mr/Ms/Mrs {Name}";
    }

    string IPerson.GetName()
    {
        return $"{Name}";
    }
}

