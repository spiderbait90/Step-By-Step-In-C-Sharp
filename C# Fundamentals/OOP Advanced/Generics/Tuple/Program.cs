using System;

public class Program
{
    public static void Main(string[] args)
    {
        var fi = Console.ReadLine()
            .Split(new[] { ' ' });

        var si = Console.ReadLine()
            .Split(new[] { ' ' });

        var ti = Console.ReadLine()
            .Split(new[] { ' ' });

        var t1 = new Threeuple<string, string, string>(fi[0] + " " + fi[1], fi[2], fi[3]);

        var t2 = new Threeuple<string, int, bool>(si[0],
            int.Parse(si[1]), si[2] == "drunk");

        var t3 = new Threeuple<string, double, string>(ti[0], double.Parse(ti[1]), ti[2]);

        Console.WriteLine(t1);
        Console.WriteLine(t2);
        Console.WriteLine(t3);
    }
}

