using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    static void Main(string[] args)
    {

        var animals = new List<Animal>();

        var countLines = 0;
        var index = -1;
        while (true)
        {
            try
            {
                var input = Console.ReadLine();
                if (input == "End")
                    break;

                var tokens = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (countLines % 2 == 0)
                {

                    Animal animal = null;
                    switch (tokens[0])
                    {
                        case "Owl": animal = new Owl(tokens[1], double.Parse(tokens[2]), double.Parse(tokens[3])); break;
                        case "Hen": animal = new Hen(tokens[1], double.Parse(tokens[2]), double.Parse(tokens[3])); break;
                        case "Mouse": animal = new Mouse(tokens[1], double.Parse(tokens[2]), tokens[3]); break;
                        case "Dog": animal = new Dog(tokens[1], double.Parse(tokens[2]), tokens[3]); break;
                        case "Cat": animal = new Cat(tokens[1], double.Parse(tokens[2]), tokens[3], tokens[4]); break;
                        case "Tiger": animal = new Tiger(tokens[1], double.Parse(tokens[2]), tokens[3], tokens[4]); break;
                    }
                    animals.Add(animal);
                    index++;
                }
                else
                {
                    Food food = null;
                    switch (tokens[0])
                    {
                        case "Vegetable": food = new Vegetable(int.Parse(tokens[1])); break;
                        case "Fruit": food = new Fruit(int.Parse(tokens[1])); break;
                        case "Meat": food = new Meat(int.Parse(tokens[1])); break;
                        case "Seeds": food = new Seeds(int.Parse(tokens[1])); break;
                    }

                    Console.WriteLine(animals[index].ProduceSound());
                    animals[index].GiveFood(food);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            countLines++;
        }

        foreach (var a in animals)
        {
            Console.WriteLine(a.ToString());
        }
    }
}
