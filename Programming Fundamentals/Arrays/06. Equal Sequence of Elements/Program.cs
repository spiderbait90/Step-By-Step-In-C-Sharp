using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Equal_Sequence_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            var button = true;
            var firstNumber = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] != firstNumber)
                    button = false;
                    
            }
            if (button==false)
                Console.WriteLine("No");
            else
                Console.WriteLine("Yes");
        }
    }
}
