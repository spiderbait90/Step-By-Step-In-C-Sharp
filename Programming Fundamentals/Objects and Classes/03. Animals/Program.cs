using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Animals
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var dogs = new Dictionary<string, Dog>();
            var cats = new Dictionary<string, Cat>();
            var snakes = new Dictionary<string, Snake>();

            while (input != "I'm your Huckleberry")
            {
                var split = input.Split(new[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);

                if (split.Length == 4)
                {
                    var kind = split[0]; var name = split[1];
                    var age = int.Parse(split[2]);
                    var mixNumb = int.Parse(split[3]);
                    if (kind == "Dog")
                    {
                        var dog = new Dog();
                        dog.Name = name;
                        dog.Age = age;
                        dog.NumberOfLegs = mixNumb;
                        dogs[name] = dog;
                    }
                    else if (kind == "Cat")
                    {
                        var cat = new Cat();
                        cat.Name = name;
                        cat.Age = age;
                        cat.Intelligence = mixNumb;
                        cats[name] = cat;
                    }
                    else if (kind == "Snake")
                    {
                        var snake = new Snake();
                        snake.Name = name;
                        snake.Age = age;
                        snake.CrueltyCoefficient = mixNumb;
                        snakes[name] = snake;
                    }
                }
                else if (split.Length == 2)
                {
                    var name = split[1];
                    if (dogs.ContainsKey(name))
                        dogs[name].ProduceSound();
                    else if (cats.ContainsKey(name))
                        cats[name].ProduceSound();
                    else if (snakes.ContainsKey(name))
                        snakes[name].ProduceSound();
                }
                input = Console.ReadLine();
            }
            foreach (var dog in dogs.Values)
            {
                Console.WriteLine($"Dog: {dog.Name}, Age: {dog.Age}, " +
                    $"Number Of Legs: {dog.NumberOfLegs}");
            }
            foreach (var cat in cats.Values)
            {
                Console.WriteLine($"Cat: {cat.Name}, Age: {cat.Age}," +
                    $" IQ: {cat.Intelligence}");
            }
            foreach (var snake in snakes.Values)
            {
                Console.WriteLine($"Snake: {snake.Name}, Age: {snake.Age}," +
                    $" Cruelty: {snake.CrueltyCoefficient}");
            }

        }
    }

    public class Dog
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int NumberOfLegs { get; set; }

        public void ProduceSound()
        {
            Console.WriteLine("I'm a Distinguishedog, and I will" +
                " now produce a distinguished sound! Bau Bau.");
        }
    }
    public class Cat
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Intelligence { get; set; }

        public void ProduceSound()
        {
            Console.WriteLine("I'm an Aristocat, and I will now " +
                "produce an aristocratic sound! Myau Myau.");
        }
    }
    public class Snake
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int CrueltyCoefficient { get; set; }

        public void ProduceSound()
        {
            Console.WriteLine("I'm a Sophistisnake, and I will now " +
                "produce a sophisticated sound! Honey, I'm home.");
        }
    }
}
