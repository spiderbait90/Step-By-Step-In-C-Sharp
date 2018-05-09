using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Animal
{
    protected Animal(string name, double weight)
    {
        Name = name;
        Weight = weight;
    }
    public string Name { get; set; }

    public double Weight { get; set; }

    public int FoodEaten { get; set; }

    public abstract string ProduceSound();

    public abstract void GiveFood(Food food);
}

