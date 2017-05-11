using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Spyfer
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split()
                .Select(int.Parse).ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers.Count == 1)
                    break;
                if (i == 0)
                {
                    if (numbers[0] == numbers[1])
                    {
                        numbers.RemoveAt(1);
                        i = -1;
                    }
                }
                else if (i == numbers.Count - 1)
                {
                    if (numbers[numbers.Count - 1] == numbers[numbers.Count - 2])
                    {
                        numbers.RemoveAt(numbers.Count - 2);
                        i = -1;
                    }
                }
                else if (numbers[i - 1] + numbers[i + 1] == numbers[i]
                    && i > 0 && i <numbers.Count-1)
                {
                    numbers.RemoveAt(i - 1);
                    numbers.RemoveAt(i);
                    i = -1;
                }
            }

            Console.WriteLine(string.Join(" ", numbers));

        }
    }
}
