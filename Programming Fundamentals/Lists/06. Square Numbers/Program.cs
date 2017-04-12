using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Square_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ')
                .Select(int.Parse).ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (Math.Sqrt(numbers[i]) == (int)Math.Sqrt(numbers[i]))
                {
                    continue;
                }
                else
                {
                    numbers.RemoveAt(i);
                    i = -1;
                }
            }
            numbers.Sort();
            numbers.Reverse();
            Console.WriteLine(string.Join(" ",numbers));

        }
    }
}
