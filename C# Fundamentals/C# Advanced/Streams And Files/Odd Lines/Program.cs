using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Lines
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var stream = new StreamReader(@"C:\Users\spide\Desktop\03. Streams-Exercise\words.txt"))
            {
                string line = stream.ReadLine();
                var count = 0;
                while (line != null)
                {
                    if (count % 2 != 0)
                        Console.WriteLine(line);
                    count++;
                    line = stream.ReadLine();
                }
            }
        }
    }
}
