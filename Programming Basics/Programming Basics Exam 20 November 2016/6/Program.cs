using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            var digit = int.Parse(Console.ReadLine());
            var count = 0;
            for (int a = num1; a <= num2; a++)
            {
                for (int b = num1; b <= num2; b++)
                {                    
                    Console.Write($"<{a}-{b}>");
                    count++;
                    if (digit == count)
                    {
                        Console.WriteLine();
                        return;
                    }
                }
            }
            Console.WriteLine();
        }
        
    }
}
