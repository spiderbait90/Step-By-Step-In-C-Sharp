using System;

public class Dog : Mammal
{
    public override void GiveFood(Food food)
    {
        if (food.GetType().Name == "Meat")
        {
            Weight += (food.Quantity * 0.40);
            FoodEaten += food.Quantity;
        }
        else
        {
            throw new ArgumentException($"{this.GetType().Name} does not eat {food.GetType().Name}!");
        }
    }


    public Dog(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
    {
    }

    public override string ProduceSound()
    {
        return "Woof!";
    }

    
}
