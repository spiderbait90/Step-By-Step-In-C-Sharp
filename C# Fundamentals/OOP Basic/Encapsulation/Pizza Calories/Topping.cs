using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Topping
{
    public Topping(string type, double weight)
    {
        Type = type;
        Weight = weight;
    }

    private string type;

    public string Type
    {
        get { return type; }
        set
        {
            if (value.ToLower() != "meat" &&
                value.ToLower() != "veggies" &&
                value.ToLower() != "cheese" &&
                value.ToLower() != "sauce")
                throw new ArgumentException($"Cannot place {value} on top of your pizza.");

            type = value;
        }
    }

    private double weight;

    public double Weight
    {
        get { return weight; }
        set
        {
            if (value < 1 || value > 50)
                throw new ArgumentException($"{Type} weight should be in the range [1..50].");
            weight = value;
        }
    }

    public double CalculateCalories()
    {
        double cal = 0;

        switch (Type.ToLower())
        {
            case "meat":
                cal = 1.2;
                break;
            case "veggies":
                cal = 0.8;
                break;
            case "cheese":
                cal = 1.1;
                break;
            case "sauce":
                cal = 0.9;
                break;
        }

        return (Weight * 2) * cal;
    }
}

