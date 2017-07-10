using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split()
                .Select(long.Parse).ToList();
            long sum = 0;
            while(numbers.Count>0)
            {
                var index = int.Parse(Console.ReadLine());
                if (index>=0&&index<numbers.Count)
                {
                    var value = numbers[index];
                    sum += numbers[index];
                    numbers.RemoveAt(index);
                    IncreaseOrDecrese( numbers, value);
                }
                else
                {
                    if (index<0)
                    {
                        var value = numbers[0];
                        sum += numbers[0];
                        numbers[0] = numbers[numbers.Count - 1];
                        IncreaseOrDecrese( numbers, value);
                    }
                    else if (index>numbers.Count-1)
                    {
                        var value = numbers[numbers.Count - 1];
                        sum += numbers[numbers.Count - 1];
                        numbers[numbers.Count - 1] = numbers[0];
                        IncreaseOrDecrese( numbers, value);
                    }
                }
            }
            Console.WriteLine(sum);
        }

        public static void IncreaseOrDecrese(List<long> numbers, long value)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] <= value)
                    numbers[i] += value;
                else
                    numbers[i] -= value;
            }
        }
    }
}
