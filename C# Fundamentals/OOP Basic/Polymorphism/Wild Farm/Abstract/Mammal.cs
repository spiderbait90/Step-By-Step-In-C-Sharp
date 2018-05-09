using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class Mammal:Animal
{
    protected Mammal(string name, double weight,string livingRegion) : base(name, weight)
    {
        LivingRegion = livingRegion;
    }
    public string LivingRegion { get; set; }

    public override string ToString()
    {
        return $"{this.GetType().Name} [{Name}, {Weight}, {LivingRegion}, {FoodEaten}]";
    }
}

