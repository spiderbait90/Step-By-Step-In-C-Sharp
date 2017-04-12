using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            var letters = Console.ReadLine().ToCharArray();

            var alphabet = new int[26];
            var alphabedConv = new char[26];
            for (int i = 0; i < alphabet.Length; i++)
            {
                alphabet[i] = 'a'+i;                
            }
            for (int a = 0; a < letters.Length; a++)
            {
                for (int b = 0; b <alphabet.Length ; b++)
                {
                    if (letters[a]==alphabet[b])
                        Console.WriteLine($"{letters[a]} -> {b}");
                }
            }
            
        }
    }
}
