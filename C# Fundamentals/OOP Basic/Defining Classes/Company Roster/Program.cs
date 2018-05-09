using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    public static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var data = new Dictionary<string, List<Employee>>();

        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var name = input[0];
            var salary = decimal.Parse(input[1]);
            var position = input[2];
            var department = input[3];
            string email = "n/a";
            int age = -1;

            if (input.Length == 6)
            {
                email = input[4];
                age = int.Parse(input[5]);
            }
            else if (input.Length == 5)
            {
                if (!int.TryParse(input[4], out age))
                {
                    email = input[4];
                    age = -1;
                }
            }

            if (!data.ContainsKey(department))
                data[department] = new List<Employee>();

            data[department].Add(new Employee()
            {
                Name = name,
                Salary = salary,
                Department = department,
                Position = position,
                Email = email,
                Age = age
            });
        }

        var result = data.Values.OrderByDescending(x => x.Average(a => a.Salary)).First();

        Console.WriteLine($"Highest Average Salary: {result.First().Department}");

        foreach (var e in result.OrderByDescending(x => x.Salary))
        {
            Console.WriteLine($"{e.Name} {e.Salary:f2} {e.Email} {e.Age}");
        }
    }
}

