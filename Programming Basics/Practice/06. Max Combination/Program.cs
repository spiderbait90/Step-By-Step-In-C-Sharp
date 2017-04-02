using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Max_Combination
{
    class Program
    {
        static void Main(string[] args)
        {
            var Start = int.Parse(Console.ReadLine());
            var Finish = int.Parse(Console.ReadLine());
            var Stop = int.Parse(Console.ReadLine());
            var count = 0;

            for (int a = Start; a <= Finish; a++)
            {
                for (int b = Start; b <= Finish; b++)
                {
                    count++;
                    Console.Write($"<{a}-{b}>");
                    if (Stop==count)
                    {
                        Console.WriteLine();
                        return;
                    }
                }
            }
        }
    }
}
