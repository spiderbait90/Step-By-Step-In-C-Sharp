using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

public class Engine
{
    public Engine()
    {
        
    }
    public Engine(string model, int power)
    {
        Model = model;
        Power = power;
    }

    public Engine(string model, int power, int displacement, string efficiency) : this(model, power)
    {
        Displacement = displacement;
        Efficiency = efficiency;
    }

    public string Model { get; set; }

    public int Power { get; set; }

    public int Displacement { get; set; }

    public string Efficiency { get; set; }
}

