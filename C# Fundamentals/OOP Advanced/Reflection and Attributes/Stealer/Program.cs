using System;


public class Program
{
    public static void Main(string[] args)
    {
        var spy = new Spy();
        var reasult = spy.CollectGettersAndSetters("Hacker");
        Console.WriteLine(reasult);
    }
}

