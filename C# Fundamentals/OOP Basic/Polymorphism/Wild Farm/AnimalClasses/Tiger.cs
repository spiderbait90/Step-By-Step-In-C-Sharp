using System;

public class Tiger:Feline
{
    public Tiger(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
    {
    }
    
    public override string ProduceSound()
    {
        return "ROAR!!!";
    }

    public override void GiveFood(Food food)
    {
        if (food.GetType().Name == "Meat")
        {
            Weight += (food.Quantity * 1.00);
            FoodEaten += food.Quantity;
        }
        else
        {
            throw new ArgumentException($"{this.GetType().Name} does not eat {food.GetType().Name}!");
        }
    }

    
}