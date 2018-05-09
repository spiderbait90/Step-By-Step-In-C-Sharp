using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Dough
{
    public Dough(string flourType, string bakingTechnique, double weight)
    {
        FlourType = flourType;
        BakingTechnique = bakingTechnique;
        Weight = weight;
    }

    private string flourType;

    public string FlourType
    {
        get { return flourType; }
        set
        {
            if (value.ToLower() != "white" &&
                value.ToLower() != "wholegrain")
                throw new ArgumentException("Invalid type of dough.");

            flourType = value;
        }
    }

    private string bakingTechnique;

    public string BakingTechnique
    {
        get { return bakingTechnique; }
        set
        {
            if (value.ToLower() != "crispy" &&
                value.ToLower() != "chewy" &&
                value.ToLower() != "homemade")
                throw new ArgumentException("Invalid type of dough.");

            bakingTechnique = value;
        }
    }

    private double weight;

    public double Weight
    {
        get { return weight; }
        set
        {
            if (value < 1 || value > 200)
                throw new ArgumentException("Dough weight should be in the range [1..200].");

            weight = value;
        }
    }

    public double CalculateCalories()
    {
        double cal1 = 0;
        double cal2 = 0;

        switch (FlourType.ToLower())
        {
            case "white": cal1 = 1.5; break;
            case "wholegrain": cal1 = 1.0; break;
        }

        switch (bakingTechnique.ToLower())
        {
            case "crispy": cal2 = 0.9; break;
            case "chewy": cal2 = 1.1; break;
            case "homemade": cal2 = 1.0; break;
        }
        return (Weight * 2) * cal2 * cal1;
    }
}

