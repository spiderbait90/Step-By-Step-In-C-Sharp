using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText("words.txt", Console.ReadLine());
            File.WriteAllText
                ("input.txt", @"-I was quick to judge him, but it wasn't his fault.
                 -Is this some kind of joke?! Is it?
                 -Quick, hide here…It is safer.");
            var words = File.ReadAllText("words.txt").Split();
            var input = File.ReadAllText("input.txt")
                .Split(new[] {'-','.',',','!','?',' '}
                ,StringSplitOptions.RemoveEmptyEntries);
            var result = new Dictionary<string, int>();
            foreach (var word in words)
            {
                foreach (var item in input)
                {
                    if (word.ToLower()==item.ToLower())
                    {
                        if (!result.ContainsKey(word))
                            result[word] = 1;
                        else
                            result[word]++;
                    }
                }
            }
            foreach (var item in result)
            {
                File.AppendAllText("Output.txt", 
                    $"{item.Key} - {item.Value} {Environment.NewLine}");
            }
            File.OpenRead("Output.txt");
        }
    }
}
