using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Ferrari:ICar
{
    public Ferrari(string driver)
    {
        Model = "488-Spider";
        Driver = driver;
    }

    public string Model { get; set; }
    public string Driver { get; set; }
    public string Breaks()
    {
        return "Brakes!";
    }

    public string Gas()
    {
        return "Zadu6avam sA!";
    }

    public override string ToString()
    {
        return $"{Model}/{Breaks()}/{Gas()}/{Driver}";
    }
}

