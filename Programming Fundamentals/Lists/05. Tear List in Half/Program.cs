using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Tear_List_in_Half
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ')
                .Select(int.Parse).ToList();

            var topNumbers = new List<int>();
            var botNumbers = new List<int>();
            for (int i = numbers.Count/2; i < numbers.Count; i++)
            {
                topNumbers.Add(numbers[i]);
                botNumbers.Add(numbers[i-numbers.Count / 2]);
            }
            var count = 0;
            for (int i = 0; i <= int.MaxValue; i+=3)
            {
                botNumbers.Insert(i, topNumbers[count] / 10);
                botNumbers.Insert(i+2, topNumbers[count] % 10);
                count++;
                if (count == numbers.Count / 2)
                    break;
            }
            Console.WriteLine(string.Join(" ",botNumbers));

        }
    }
}
