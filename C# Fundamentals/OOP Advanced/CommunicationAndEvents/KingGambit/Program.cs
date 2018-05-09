using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    public static void Main(string[] args)
    {
        var king = new King(Console.ReadLine());

        var guards = Console.ReadLine().Split().Select(x => new RoyalGuard(x)).ToList();
        var footmen = Console.ReadLine().Split().Select(x => new Footman(x)).ToList();

        while (true)
        {
            var input = Console.ReadLine().Split();
            if (input[0] == "End")
                break;

            if (input[0] == "Attack")
            {
                Console.WriteLine(king);
                if (guards.Any())
                    Console.WriteLine(string.Join(Environment.NewLine, guards));

                if (footmen.Any())
                    Console.WriteLine(string.Join(Environment.NewLine, footmen));
            }
            else if (input[0] == "Kill")
            {
                var index = footmen.FindIndex(x => x.Name == input[1]);

                if (index == -1)
                {
                    index = guards.FindIndex(x => x.Name == input[1]);
                    guards.RemoveAt(index);
                }
                else
                {
                    footmen.RemoveAt(index);
                }

            }
        }
    }
}

