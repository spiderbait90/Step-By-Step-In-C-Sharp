using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        var set = new HashSet<Person>();
        var set2 = new SortedSet<Person>();

        var n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine().Split();
            var person = new Person(input[0], int.Parse(input[1]));

            set.Add(person);
            set2.Add(person);
        }

        Console.WriteLine(set.Count);
        Console.WriteLine(set2.Count);
    }
}

