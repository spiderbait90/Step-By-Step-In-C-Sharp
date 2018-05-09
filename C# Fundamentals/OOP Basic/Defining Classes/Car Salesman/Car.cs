﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Car
{
    public Car(string model, Engine engine, int weight, string color)
    {
        Model = model;
        Engine = engine;
        Weight = weight;
        Color = color;
    }
    
    public string Model { get; set; }

    public Engine Engine { get; set; }

    public int Weight { get; set; }

    public string Color { get; set; }
}

