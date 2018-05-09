using System;

public class Cat:Feline
{

    public Cat(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
    {
    }

    public override void GiveFood(Food food)
    {
        if (food.GetType().Name == "Meat" ||
            food.GetType().Name == "Vegetable")
        {
            Weight += (food.Quantity * 0.30);
            FoodEaten += food.Quantity;
        }
        else
        {
            throw new ArgumentException($"{this.GetType().Name} does not eat {food.GetType().Name}!");
        }
    }

    public override string ProduceSound()
    {
        return "Meow";
    }

    
}
