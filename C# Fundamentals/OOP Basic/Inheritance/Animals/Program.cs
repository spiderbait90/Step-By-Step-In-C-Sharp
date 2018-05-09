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

        while (true)
        {
            try
            {
                var kind = Console.ReadLine();

                if (kind == "Beast!")
                    break;

                var stats = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var animal = CreateAnimal(kind, stats);

                animals.Add(animal);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
           
        }

        foreach (var animal in animals)
        {
            Console.WriteLine(animal.GetType().Name);
            Console.WriteLine($"{animal.Name} {animal.Age} {animal.Gender}");
            animal.ProduceSound();
        }
    }

    public static Animal CreateAnimal(string kind, string[] stats)
    {
        switch (kind)
        {
            case "Cat": return new Cat(stats[0], int.Parse(stats[1]), stats[2]);
            case "Dog": return new Dog(stats[0], int.Parse(stats[1]), stats[2]);
            case "Frog": return new Frog(stats[0], int.Parse(stats[1]), stats[2]);
            case "Kitten": return new Kitten(stats[0], int.Parse(stats[1]));
            case "Tomcat": return new Tomcat(stats[0], int.Parse(stats[1]));
            default: throw new ArgumentException("Invalid input!");
        }

    }
}

