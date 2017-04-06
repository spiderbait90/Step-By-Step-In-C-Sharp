using System;
using System.Collections.Generic;

public class BePositive_broken
{
    public static void Main()
    {
        var delimiter = Console.ReadLine();
        var numberOfStrings = int.Parse(Console.ReadLine());

        var result = string.Empty;
        var currentString = string.Empty;

        for (int i = 1; i <= numberOfStrings; i++)
        {
            currentString = Console.ReadLine();
            result += currentString;
            if (i != numberOfStrings)
            {
                result += delimiter;
            }
        }


        Console.WriteLine(result);
    }
}