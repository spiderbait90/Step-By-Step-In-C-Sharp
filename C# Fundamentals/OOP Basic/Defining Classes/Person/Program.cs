using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    public static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var family = new Family();

        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine().Split(' ');

            var name = input[0];
            var age = int.Parse(input[1]);

            var person = new Person();
            person.Name = name;
            person.Age = age;

            family.AddMember(person);
        }

        var result = family.AllAbove30();

        foreach (var person in result)
        {
            Console.WriteLine($"{person.Name} - {person.Age}");
        }
       
    }
}

