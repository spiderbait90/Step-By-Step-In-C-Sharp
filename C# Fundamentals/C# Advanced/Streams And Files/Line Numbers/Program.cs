using System;
using System.IO;

namespace Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var streamReader = new StreamReader(@"C:\Users\spide\Desktop\03. Streams-Exercise\text.txt"))
            {
                using (var streamWriter = new StreamWriter("Output.txt"))
                {
                    string line = streamReader.ReadLine();
                    var count = 1;
                    while (line != null)
                    {
                        streamWriter.WriteLine($"Line {count}: {line}");
                        count++;
                        line = streamReader.ReadLine();
                    }
                }
            }
        }
    }
}
