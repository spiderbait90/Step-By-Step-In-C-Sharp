using System;


public class Program
{
   public static void Main(string[] args)
    {
        var disp = new Dispatcher();
        var handler = new Handler();
        disp.NameChange += handler.OnDispatcherNameChange;

        while (true)
        {
            var input = Console.ReadLine();
            if (input=="END")
                break;

            disp.Name = input;
        }
    }
}

