using System;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        var input = Console.ReadLine()
            .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse).ToList();

        var lake = new Lake(input);

        Console.WriteLine(string.Join(", ",lake));
    }
}

