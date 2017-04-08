using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Array_Symmetry
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine()
                .Split()
                .ToArray();
            var button = true;
            for (int i = 0; i < words.Length; i++)
            {
                var firstWord = words[i];
                var secondWord = words[words.Length - 1 - i];
                if (firstWord!=secondWord)
                {
                    button = false;
                }                    
            }
            if (button)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            
            
        }
    }
}
