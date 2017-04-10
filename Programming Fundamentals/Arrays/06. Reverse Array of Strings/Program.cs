using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var letters = Console.ReadLine()
                .Split(' ')               
                .ToArray();
            var reverse = new string[letters.Length];
            var result = new string[letters.Length];
            for (int i = 0; i < letters.Length; i++)
            {
                reverse[i] = letters[letters.Length - 1 - i];
                result[i] = reverse[i];
            }
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
