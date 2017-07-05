using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _Practice
{
    class _Practice
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine().Where(x => x != ' ')
                .ToArray();
            var input = new string(line);
            var minIndex = int.MaxValue;
            
            for (int i = 0; i < input.Length; i++)
            {
                var first = input.IndexOf(input[i]);
                var second = input.IndexOf(input[i], first + 1);
                if (second >= 0 && second < minIndex)
                    minIndex = second;
            }
            if (minIndex==int.MaxValue)
                Console.WriteLine("-1");
            else
                Console.WriteLine(minIndex);
        }
    }
}
