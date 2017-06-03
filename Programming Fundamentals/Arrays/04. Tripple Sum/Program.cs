using System;
using System.Linq;

namespace _04.Tripple_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ')
                .Select(int.Parse).ToArray();
            var check = false;
            for (int a = 0; a < numbers.Length; a++)
            {
                for (int b = a + 1; b < numbers.Length; b++)
                {
                    if (numbers.Contains(numbers[a] + numbers[b]))
                    {
                        Console.WriteLine($"{numbers[a]} + {numbers[b]} == " +
                        $"{numbers[a] + numbers[b]}");
                        check = true;
                    }
                }
            }
            if (!check)
                Console.WriteLine("No");
        }
    }
}
