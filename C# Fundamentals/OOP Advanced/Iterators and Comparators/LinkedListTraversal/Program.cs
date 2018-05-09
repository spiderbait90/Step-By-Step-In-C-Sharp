using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        var list = new CustomLinkedList<int>();
        var n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine().Split(new[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);

            var command = input[0];
            var num = int.Parse(input[1]);

            if (command == "Add")
            {
                list.Add(num);
            }

            if (command == "Remove")
            {
                list.Remove(num);
            }
        }

        Console.WriteLine(list.Count());
        Console.WriteLine(string.Join(" ",list));
    }
}

