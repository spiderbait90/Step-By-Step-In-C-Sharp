using System;
using System.Collections.Generic;


public class Program
{
    public static void Main(string[] args)
    {
        var set = new SortedSet<Person>(new NameComparator());
        var set2 = new SortedSet<Person>(new AgeComparator());

        var n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine().Split();
            var person = new Person(input[0],int.Parse(input[1]));

            set.Add(person);
            set2.Add(person);
        }

        Console.WriteLine(string.Join(Environment.NewLine,set));
        Console.WriteLine(string.Join(Environment.NewLine,set2));
    }
}

