using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var members = new List<IBuyer>();

        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine().Split(' ');

            if (input.Length == 4)
            {
                var citizen = new Citizen(input[0], input[1], input[2], input[3]);

                members.Add(citizen);
            }
            else
            {
                var rebel = new Rebel(input[0], input[1], input[2]);
                members.Add(rebel);
            }
        }

        while (true)
        {
            var name = Console.ReadLine();

            if (name == "End")
                break;

           members.FirstOrDefault(x => x.Name == name)?.BuyFood();

            
        }

        Console.WriteLine(members.Sum(x=>x.Food));

    }
}

