using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Predicate_Party_
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            while (true)
            {
                var command = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (command[0] == "Party!")
                    break;

                names = ChangeCollection(command, names);
            }

            if (names.Count == 0)
                Console.WriteLine("Nobody is going to the party!");
            else
            {
                Console.WriteLine(string.Join(", ", names)+ " are going to the party!");
            }
            
        }
        private static List<string> ChangeCollection(string[] command, List<string> names)
        {
            var changedNames = new List<string>();

            if (command[1] == "StartsWith")
            {
                if (command[0] == "Remove")
                {
                    changedNames = names.Where(x => !x.StartsWith(command[2])).ToList();
                }
                else
                {
                    for (int i = 0; i < names.Count; i++)
                    {
                        if (names[i].StartsWith(command[2]))
                        {
                            names.Insert(i, names[i]);
                            i++;
                        }
                    }
                    changedNames = names;
                }
            }
            else if (command[1] == "EndsWith")
            {
                if (command[0] == "Remove")
                {
                    changedNames = names.Where(x => !x.EndsWith(command[2])).ToList();
                }
                else
                {
                    for (int i = 0; i < names.Count; i++)
                    {
                        if (names[i].EndsWith(command[2]))
                        {
                            names.Insert(i, names[i]);
                            i++;
                        }
                    }
                    changedNames = names;
                }
            }
            else if (command[1] == "Length")
            {
                var parsed = int.Parse(command[2]);
                if (command[0] == "Remove")
                {
                    changedNames = names.Where(x => x.Length != parsed)
                        .ToList();
                }
                else
                {
                    for (int i = 0; i < names.Count; i++)
                    {
                        if (names[i].Length == parsed)
                        {
                            names.Insert(i, names[i]);
                            i++;
                        }
                    }
                    changedNames = names;
                }
            }
            return changedNames;
        }
    }
}
