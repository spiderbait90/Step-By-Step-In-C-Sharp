using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Roli_The_Coder
{
    class Program
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine();

            var data = new Dictionary<string, List<string>>();

            var idCheck = new Dictionary<int, string>();

            while (input != "Time for Code")
            {
                var split = input.Split(new[] { ' ' }
                , StringSplitOptions.RemoveEmptyEntries);

                var id = int.Parse(split[0]);
                var eventName = split[1];
                var participants = split.Skip(2).ToList();

                if (eventName[0] != '#')
                {

                }
                else
                {
                    if (idCheck.ContainsKey(id))
                    {
                        if (idCheck[id] == eventName)
                        {
                            foreach (var name in participants)
                            {
                                if (!data[eventName].Contains(name))
                                    data[eventName].Add(name);
                            }
                        }
                    }
                    else if (!idCheck.ContainsKey(id))
                    {
                        data[eventName] = new List<string>();
                        idCheck[id] = eventName;

                        foreach (var name in participants)
                        {
                            if (!data[eventName].Contains(name))
                                data[eventName].Add(name);
                        }
                    }
                }
                input = Console.ReadLine();
            }
            foreach (var eventt in data
                .OrderByDescending(x=>x.Value.Count)
                .ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{eventt.Key.Remove(0,1)} - {eventt.Value.Count}");
                foreach (var name in eventt.Value.OrderBy(x=>x))
                {
                    Console.WriteLine($"{name}");
                }
            }
        }
    }
}
