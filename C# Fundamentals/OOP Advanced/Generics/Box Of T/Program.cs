using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var list = new List<double>();

        for (int i = 0; i < n; i++)
        {
            var input = double.Parse(Console.ReadLine());
            list.Add(input);
        }

        var element = double.Parse(Console.ReadLine());

        Console.WriteLine(Box<double>.Compare(list,element));
    }
}

