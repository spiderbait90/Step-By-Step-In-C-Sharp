using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var phoneBook = new Dictionary<string, string>();

            while (input!="END")
            {
                var split = input.Split();

                var command = split[0];
                var name = split[1];                

                if (command=="A")
                {
                    var number = split[2];
                    phoneBook[name] = number;
                }
                else if (command=="S")
                {
                    if (!phoneBook.ContainsKey(name))
                        Console.WriteLine($"Contact {name} does not exist.");
                    else
                        Console.WriteLine($"{name} -> {phoneBook[name]}");
                }
                input = Console.ReadLine();
            }
        }
    }
}
