public class Hen:Bird
{
    public Hen(string name, double weight, double wingSize) : base(name, weight, wingSize)
    {
    }

    public override string ProduceSound()
    {
        return "Cluck";
    }

    public override void GiveFood(Food food)
    {
        Weight += (food.Quantity * 0.35);
        FoodEaten += food.Quantity;
    }

    
}
