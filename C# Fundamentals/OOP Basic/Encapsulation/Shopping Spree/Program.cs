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
            var persons = GetPersons();
            var products = GetProducts();

            while (true)
            {
                var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (input[0] == "END")
                    break;

                var person = persons.Find(x => x.Name == input[0]);
                var product = products.Find(x => x.Name == input[1]);

                if (person.Money >= product.Cost)
                {
                    person.Products.Add(product);
                    person.Money -= product.Cost;

                    Console.WriteLine($"{person.Name} bought {product.Name}");
                }
                else
                {
                    Console.WriteLine($"{person.Name} can't afford {product.Name}");
                }
            }

            foreach (var p in persons)
            {
                Console.WriteLine(p.Products.Count == 0 ? $"{p.Name} - Nothing bought" : $"{p.Name} - {string.Join(", ", p.Products.Select(x => x.Name))}");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

    }

    public static List<Person> GetPersons()
    {
        var input = Console.ReadLine().Split(new[] { ';', '=', ' ' }, StringSplitOptions.RemoveEmptyEntries);

        var list = new List<Person>();

        for (int i = 0; i < input.Length; i += 2)
        {
            var person = new Person(input[i], decimal.Parse(input[i + 1]));
            list.Add(person);
        }

        return list;
    }

    public static List<Product> GetProducts()
    {
        var input = Console.ReadLine().Split(new[] { ';', '=', ' ' }, StringSplitOptions.RemoveEmptyEntries);

        var list = new List<Product>();

        for (int i = 0; i < input.Length; i += 2)
        {
            var product = new Product(input[i], decimal.Parse(input[i + 1]));
            list.Add(product);
        }

        return list;
    }
}

