using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine()
                .Split()
                .ToArray();
            var extractedNumbers = new long[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                if (i % 2 == 0)
                    extractedNumbers[i] = long.Parse(text[i]);

            }
            long altitude = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (i == 0)
                {
                    altitude = extractedNumbers[i];
                }
                else if (i % 2 != 0)
                {
                    if (text[i] == "up")
                    {
                        altitude += extractedNumbers[i + 1];
                    }
                    else if (text[i] == "down")
                    {
                        altitude -= extractedNumbers[i + 1];
                    }
                }
                if (altitude <= 0)
                {
                    Console.WriteLine("crashed"); return;
                }
            }
            Console.WriteLine($"got through safely. current altitude: {altitude}m");
        }


    }
}
