using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Average_Character_Delimiter
{
    class Program
    {
        static void Main(string[] args)
        {
            var letters = Console.ReadLine().Split().ToArray();
            var sum = 0;
            var count = 0;
            foreach (var str in letters)
            {
                foreach (var letter in str)
                {
                    sum += letter;
                    count++;
                }
            }
            sum /= count;
            var result = (char)sum;
            Console.WriteLine(string.Join($"{result.ToString().ToUpper()}",letters));
        }
    }
}
