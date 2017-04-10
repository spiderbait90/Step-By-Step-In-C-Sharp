using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .ToArray();
            var names = Console.ReadLine()
                .Split()
                .ToArray();
            var input = Console.ReadLine();
            var result = string.Empty;
            
            while (input!="done")
            {
                
                for (int i = 0; i < names.Length; i++)
                {
                    if (input==names[i])
                    {
                        result += $"{input} -> {numbers[i]}{Environment.NewLine}";
                        
                    }
                }
                input = Console.ReadLine();
            }
            Console.Write(result);
        }
    }
}
