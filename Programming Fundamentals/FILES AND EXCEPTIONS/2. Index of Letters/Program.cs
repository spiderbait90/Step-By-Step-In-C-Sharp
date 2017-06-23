using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            File.WriteAllText("input.txt", input);
            var letters = File.ReadAllText("input.txt");
            var lines = new string[letters.Length];

            for (int i = 0; i < letters.Length; i++)
            {
                lines[i] = $"{letters[i]} -> {letters[i] - 97}";
            }
            File.WriteAllLines("Output.txt", lines);
        }
    }
}
