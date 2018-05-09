using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    public static void Main(string[] args)
    {
        var persons = new Dictionary<string, Person>();

        while (true)
        {
            var input = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (input[0] == "End")
                break;

            var name = input[0];

            if (!persons.ContainsKey(name))
            {
                persons[name] = new Person { Name = name };
            }

            if (input[1] == "company")
            {
                persons[name].Company = new Company(input[2], input[3], decimal.Parse(input[4]));
            }
            else if (input[1] == "pokemon")
            {
                persons[name].Pokemons.Add(new Pokemon(input[2], input[3]));
            }
            else if (input[1] == "parents")
            {
                persons[name].Parents.Add(new Parent(input[2], DateTime.ParseExact(input[3], "dd/MM/yyyy", CultureInfo.InvariantCulture)));
            }
            else if (input[1] == "children")
            {
                persons[name].Children.Add(new Child(input[2], DateTime.ParseExact(input[3], "dd/MM/yyyy", CultureInfo.InvariantCulture)));
            }
            else if (input[1] == "car")
            {
                persons[name].Car = new Car(input[2], long.Parse(input[3]));
            }
        }

        var nameToSearch = Console.ReadLine();
        var person = persons.First(x => x.Key == nameToSearch).Value;
        
        Console.WriteLine(person.Name);
        Console.WriteLine("Company:");
        if (person.Company != null)
            Console.WriteLine($"{person.Company.CompanyName} {person.Company.Department} {person.Company.Salary:f2}");

        Console.WriteLine("Car:");
        if (person.Car != null)
            Console.WriteLine($"{person.Car.CarModel} {person.Car.CarSpeed}");

        Console.WriteLine("Pokemon:");
        if (person.Pokemons.Count > 0)
        {
            foreach (var p in person.Pokemons)
            {
                Console.WriteLine($"{p.PokemonName} {p.PokemonType}");
            }
        }

        Console.WriteLine("Parents:");
        if (person.Parents.Count > 0)
        {
            foreach (var p in person.Parents)
            {
                Console.WriteLine($"{p.ParentName} {p.ParentBirthday.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture)}");
            }
        }

        Console.WriteLine("Children:");
        if (person.Children.Count > 0)
        {
            foreach (var p in person.Children)
            {
                Console.WriteLine($"{p.ChildName} {p.ChildBirthday.ToString("dd/MM/yyyy",CultureInfo.InvariantCulture)}");
            }
        }
    }
}

