using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Wormhole
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split().Select(long.Parse)
                .ToArray();
            long steps = 0;
            for (long i = 0; i < input.Length; i++)
            {
                steps++;
                if (input[i]!=0)
                {
                    var index = input[i];
                    input[i] = 0;
                    i = index;                    
                }
            }
            Console.WriteLine(steps);
        }
    }
}
