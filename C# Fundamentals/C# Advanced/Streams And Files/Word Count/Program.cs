using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var streamReader = new StreamReader(@"C:\Users\spide\Desktop\03. Streams-Exercise\text.txt"))
            {
                var result = new Dictionary<string, int>();
                using (var streamWriter = new StreamWriter("result.txt"))
                {
                    var allText = streamReader.ReadToEnd().Trim().ToLower().Split(new[] { ' ', '.', '!', '?', '-',',','"','\'' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                    foreach (var w in allText)
                    {
                        if (!result.ContainsKey(w))
                            result[w] = 1;
                        else
                        {
                            result[w]++;
                        }
                    }
                    foreach (var pair in result.OrderByDescending(x=>x.Value))
                    {
                        streamWriter.WriteLine($"{pair.Key} - {pair.Value}");
                    }
                }
            }
        }
    }
}
