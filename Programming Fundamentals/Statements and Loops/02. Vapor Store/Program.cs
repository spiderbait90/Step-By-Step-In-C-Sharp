using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Vapor_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            var currentBalance = double.Parse(Console.ReadLine());
            var spend = 0.0;
            while (currentBalance > 0)
            {
                var input = Console.ReadLine();

                if (input == "OutFall 4")
                {
                    if (currentBalance >= 39.99)
                    {
                        currentBalance -= 39.99;
                        spend += 39.99;
                        Console.WriteLine("Bought OutFall 4");
                    }
                    else
                        Console.WriteLine("Too Expensive");
                }
                else if (input == "CS: OG")
                {
                    if (currentBalance >= 15.99)
                    {
                        currentBalance -= 15.99;
                        spend += 15.99;
                        Console.WriteLine("Bought CS: OG");
                    }
                    else
                        Console.WriteLine("Too Expensive");
                }
                else if (input == "Zplinter Zell")
                {
                    if (currentBalance >= 19.99)
                    {
                        currentBalance -= 19.99;
                        spend += 19.99;
                        Console.WriteLine("Bought Zplinter Zell");
                    }
                    else
                        Console.WriteLine("Too Expensive");
                }
                else if (input == "Honored 2")
                {
                    if (currentBalance >= 59.99)
                    {
                        currentBalance -= 59.99;
                        spend += 59.99;
                        Console.WriteLine("Bought Honored 2");
                    }
                    else
                        Console.WriteLine("Too Expensive");
                }
                else if (input == "RoverWatch")
                {
                    if (currentBalance >= 29.99)
                    {
                        currentBalance -= 29.99;
                        spend += 29.99;
                        Console.WriteLine("Bought RoverWatch");
                    }
                    else
                        Console.WriteLine("Too Expensive");
                }
                else if (input == "RoverWatch Origins Edition")
                {
                    if (currentBalance >= 39.99)
                    {
                        currentBalance -= 39.99;
                        spend += 39.99;
                        Console.WriteLine("Bought RoverWatch Origins Edition");
                    }
                    else
                        Console.WriteLine("Too Expensive");
                }
                else if (input == "Game Time")
                    break;
                else
                    Console.WriteLine("Not Found");

            }
            if (currentBalance > 0)
                Console.WriteLine($"Total spent: ${spend:f2}. Remaining: ${currentBalance:f2}");
            else
                Console.WriteLine("Out of money!");
        }
    }
}
