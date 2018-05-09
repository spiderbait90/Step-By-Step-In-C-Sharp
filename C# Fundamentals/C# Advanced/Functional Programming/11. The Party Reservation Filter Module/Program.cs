using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.The_Party_Reservation_Filter_Module
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var filters = new Dictionary<string, List<string>>();

            while (true)
            {
                var command = Console.ReadLine()
                    .Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                if (command[0] == "Print")
                    break;

                var action = command[0];
                var type = command[1];
                var x = command[2];

                if (action == "Add filter")
                {
                    if (!filters.ContainsKey(type))
                        filters[type] = new List<string>();

                    filters[type].Add(x);
                }
                else
                {
                    filters[type].Remove(x);
                }

            }
            names = FilterNames(names, filters);

            Console.WriteLine(string.Join(" ", names));
        }

        private static List<string> FilterNames(List<string> names, Dictionary<string, List<string>> filters)
        {
            foreach (var f in filters)
            {
                if (f.Key == "Starts with")
                {
                    foreach (var x in f.Value)
                    {
                        names = names.Where(n => !n.StartsWith(x)).ToList();
                    }
                }
                else if (f.Key == "Ends with")
                {
                    foreach (var x in f.Value)
                    {
                        names = names.Where(n => !n.EndsWith(x)).ToList();
                    }
                }
                else if (f.Key == "Length")
                {
                    foreach (var x in f.Value)
                    {
                        names = names.Where(n => n.Length != int.Parse(x)).ToList();
                    }
                }
                else if (f.Key == "Contains")
                {
                    foreach (var x in f.Value)
                    {
                        names = names.Where(n => !n.Contains(x)).ToList();
                    }
                }
            }

            return names;
        }
    }
}
