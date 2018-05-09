using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            var pizzaName = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Last();

            var doughTokkens = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var dough = new Dough(doughTokkens[1], doughTokkens[2], double.Parse(doughTokkens[3]));

            var pizza = new Pizza(pizzaName, dough);

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "END")
                    break;

                var toppingTokens = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var type = toppingTokens[1];
                var weight = double.Parse(toppingTokens[2]);
                var topping = new Topping(type, weight);

                if (pizza.Toppings.Count < 10)
                    pizza.Toppings.Add(topping);
                else
                {
                    throw new ArgumentException("Number of toppings should be in range [0..10].");
                }
            }

            Console.WriteLine($"{pizza.Name} - {pizza.CalculateTotalCalories():f2} Calories.");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}

