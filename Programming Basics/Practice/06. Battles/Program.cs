using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Battles
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            var limit = int.Parse(Console.ReadLine());
            var count = 0;
            for (int a = 1; a <= num1; a++)
            {
                for (int b = 1; b <= num2; b++)
                {
                    Console.Write($"({a} <-> {b}) ");
                    count++;
                    if (count == limit)
                    {
                        Console.WriteLine();
                        return;
                    }
                }
            }
        }
    }
}
