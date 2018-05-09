using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        var people = new List<Person>();

        while (true)
        {
            var input = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (input[0] == "END")
                break;

            people.Add(new Person(input[0], int.Parse(input[1]), input[2]));
        }

        var n = int.Parse(Console.ReadLine()) - 1;
        var matches = 1;
        var noMatches = 0;
        for (int i = 0; i < people.Count; i++)
        {
            if (n==i)
                continue;
            
            if (people[n].CompareTo(people[i]) == 0)
            {
                matches++;
            }

            if (people[n].CompareTo(people[i]) != 0)
                noMatches++;
        }

        if (matches == 1)
        {
            Console.WriteLine($"No matches");
        }
        else
        {
            Console.WriteLine($"{matches} {noMatches} {people.Count}");
        }
    }
}