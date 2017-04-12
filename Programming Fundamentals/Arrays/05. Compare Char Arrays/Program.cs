using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var letters = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(char.Parse)
                .ToArray();
            var letters2 = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(char.Parse)
                .ToArray();
            var lettersSum = 0; var letters2Sum = 0;
            for (int i = 0; i < letters.Length; i++)
            {
                lettersSum += letters[i];
                
            }
            for (int i = 0; i < letters2.Length; i++)
            {
                letters2Sum += letters2[i];

            }
            if (lettersSum<=letters2Sum)
            {
                Console.WriteLine($"{string.Join("", letters)}");
                Console.WriteLine($"{string.Join("", letters2)}");
            }
            else
            {
                Console.WriteLine($"{string.Join("",letters2)}");
                Console.WriteLine($"{string.Join("",letters)}");

            }

        }
    }
}
