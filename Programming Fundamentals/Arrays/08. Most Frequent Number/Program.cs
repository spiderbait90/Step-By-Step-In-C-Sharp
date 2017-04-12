using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var currentCount = 0;
            var prevCount = 0;
            var maxNumber = 0;
            var currentNumber = 0;
            for (int a = 0; a < numbers.Length; a++)
            {
                for (int b = 0; b < numbers.Length; b++)
                {
                    if (numbers[a] == numbers[b])
                    {
                        currentCount++;
                        currentNumber = numbers[b];
                    }
                }
                if (currentCount > prevCount)
                {
                    maxNumber = currentNumber;
                    prevCount = currentCount;
                    currentCount = 0;
                }
                currentCount = 0;
            }
            Console.WriteLine(maxNumber);
        }
    }
}
