using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Jump_Around
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split()
                .Select(int.Parse).ToArray();

            var sum = 0;
            var steps = arr[0];
            var index = 0;
            while (true)
            {
                if (index + steps > arr.Length - 1)
                {
                    if (index - steps < 0)
                    {
                        sum += steps;
                        Console.WriteLine(sum);
                        return;
                    }
                    else
                    {
                        index = index - steps;
                        sum += steps;
                        steps = arr[index];
                    }
                }
                else
                {
                    index = index + steps;
                    sum += steps;
                    steps = arr[index];
                }
            }
        }
    }
}
