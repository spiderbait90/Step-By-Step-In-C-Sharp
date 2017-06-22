using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = new List<string>();
            while (true)
            {
                var line = Console.ReadLine();
                if (line == "END!")
                    break;
                text.Add(line);
            }
            File.WriteAllLines("input.txt", text);
            var readFromFile = File.ReadAllLines("input.txt").ToList();

            for (int i = 0; i < readFromFile.Count; i++)
            {
                readFromFile[i] = $"    {(i + 1).ToString()}. {readFromFile[i]}";
            }
            File.WriteAllLines("output.txt", readFromFile);
        }
    }
}
