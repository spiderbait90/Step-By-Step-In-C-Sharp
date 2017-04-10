using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Elements_Equal_to_Their_Ind
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            string extractedNumbers = "";
            
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i == numbers[i])
                {
                    extractedNumbers += i+" ";
                }
                
            }
            
            Console.WriteLine(extractedNumbers);
        }
    }
}
