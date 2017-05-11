using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Command_Interpreter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var collection = Console.ReadLine()
                .Split(new[] { ' ', '\t' },
                StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var checkEnd = Console.ReadLine();

            while (checkEnd != "end")
            {
                var command = checkEnd.Split(' ');
                var function = command[0];

                if (function == "reverse")
                {
                    reverse(command, collection);
                }
                else if (function == "sort")
                {
                    Sort(command, collection);
                }
                else if (function == "rollLeft")
                {
                    rollLeft(command, collection);
                }
                else if (function == "rollRight")
                {
                    rollRight(command, collection);
                }
                checkEnd = Console.ReadLine();
            }
            Console.WriteLine("[" + string.Join(", ", collection) + "]");
        }

        private static void reverse(string[] command, List<string> collection)
        {
            var start = int.Parse(command[2]);
            var count = int.Parse(command[4]);
            if (start < 0 || start > collection.Count-1 ||
                count < 0 || start + count > collection.Count)
            {
                Console.WriteLine("Invalid input parameters.");
                return;
            }
            collection.Reverse(start, count);
        }

        private static void Sort(string[] command, List<string> collection)
        {
            var start = int.Parse(command[2]);
            var count = int.Parse(command[4]);
            if (start < 0 || start > collection.Count-1 ||
                count < 0 || start + count > collection.Count)
            {
                Console.WriteLine("Invalid input parameters.");
                return;
            }
            collection.Sort(start, count, StringComparer.InvariantCulture);
        }

        private static void rollRight(string[] command, List<string> collection)
        {
            var count = int.Parse(command[1]) % collection.Count;
            if (count < 0)
            {
                Console.WriteLine($"Invalid input parameters.");
                return;
            }
            for (int i = 0; i < count; i++)
            {
                var temp = collection[collection.Count - 1];
                collection.RemoveAt(collection.Count - 1);
                collection.Insert(0, temp);
            }
        }

        private static void rollLeft(string[] command, List<string> collection)
        {
            var count = int.Parse(command[1]) % collection.Count;
            if (count < 0)
            {
                Console.WriteLine($"Invalid input parameters.");
                return;
            }
            for (int i = 0; i < count; i++)
            {
                var temp = collection[0];
                collection.RemoveAt(0);
                collection.Add(temp);
            }
        }
    }
}
