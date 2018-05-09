using System;

public class Mouse : Mammal
{
    public Mouse(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
    {
    }

    public override string ProduceSound()
    {
        return "Squeak";
    }

    public override void GiveFood(Food food)
    {
        
        if (food.GetType().Name == "Vegetable" ||
            food.GetType().Name == "Fruit")
        {
            Weight += (food.Quantity * 0.10);
            FoodEaten += food.Quantity;
        }
        else
        {
            throw new ArgumentException($"{this.GetType().Name} does not eat {food.GetType().Name}!");
        }
    }



}
