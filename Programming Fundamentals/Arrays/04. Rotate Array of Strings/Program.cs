using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Rotate_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            string[] words2 = new string[words.Length];

            for (int i = 0; i <words.Length-1; i++)
            {
                words2[i + 1] = words[i];
            }
            var lastElement = words[words.Length - 1];
            words2[0] = lastElement;
            Console.WriteLine(string.Join(" ",words2));
            
        }
    }
}
