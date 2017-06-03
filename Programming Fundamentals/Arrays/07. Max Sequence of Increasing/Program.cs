using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Max_Sequence_of_Increasing
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)                
                .ToArray();
            var maxSeq = 1;
            var lastStart = 0;
            var currentSeq = 1;
            var start = 0;
            for (int i = 0; i < numbers.Length-1; i++)
            {
                if (numbers[i]<numbers[i+1])
                {
                    currentSeq++;
                    if (currentSeq > maxSeq)
                    {
                        maxSeq = currentSeq;
                        lastStart = start;
                    }
                }
                else
                {
                    currentSeq = 1;
                    start = i + 1;
                }
            }

            for (int i = lastStart; i < lastStart+maxSeq; i++)
            {
                Console.Write($"{numbers[i]} ");
            }
            Console.WriteLine();
        }
    }
}
