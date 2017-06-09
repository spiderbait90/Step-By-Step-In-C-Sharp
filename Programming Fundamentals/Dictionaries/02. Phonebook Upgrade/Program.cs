using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Phonebook_Upgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var phoneBook = new SortedDictionary<string, string>();

            while (input != "END")
            {
                var split = input.Split();

                var command = split[0];                

                if (command == "A")
                {
                    var name = split[1];
                    var number = split[2];
                    phoneBook[name] = number;
                }
                else if (command == "S")
                {
                    var name = split[1];

                    if (!phoneBook.ContainsKey(name))
                        Console.WriteLine($"Contact {name} does not exist.");
                    else
                        Console.WriteLine($"{name} -> {phoneBook[name]}");
                }
                else if (command=="ListAll")
                {
                    foreach (var item in phoneBook)
                    {
                        Console.WriteLine($"{item.Key} -> {item.Value}");
                    }
                }
                input = Console.ReadLine();
            }
        }
    }
}
