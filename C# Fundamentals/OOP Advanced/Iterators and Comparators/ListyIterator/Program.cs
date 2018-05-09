using System;
using System.Linq;


public class Program
{
    public static void Main(string[] args)
    {
        var input = Console.ReadLine()
            .Split().Skip(1).ToArray();

        var iterator = new ListyIterator<string>();
        iterator.Create(input);

        while (true)
        {
            var command = Console.ReadLine();

            if (command == "END")
                break;

            if (command == "Move")
            {
                Console.WriteLine(iterator.Move());
            }
            else if (command=="HasNext")
            {
                Console.WriteLine(iterator.HasNext());
            }
            else if (command == "PrintAll")
            {
                iterator.PrintAll();
            }
            else if (command == "Print")
            {
                try
                {
                    iterator.Print();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}

