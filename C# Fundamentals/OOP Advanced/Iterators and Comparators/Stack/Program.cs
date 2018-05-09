using System;
using System.Linq;


public class Program
{
    public static void Main(string[] args)
    {
        var stack = new Stack<int>();

        while (true)
        {
            var input = Console.ReadLine().Split(new[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries);
            var command = input[0];
            var digits = input.Skip(1).Select(int.Parse).ToArray();

            if (command == "END")
                break;

            if (command == "Push")
            {
                stack.Push(digits);
            }
            if (command == "Pop")
            {
                try
                {
                    stack.Pop();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        for (int i = 0; i < 2; i++)
        {
            foreach (var n in stack.Reverse())
            {
                Console.WriteLine(n);
            }
        }
    }
}

