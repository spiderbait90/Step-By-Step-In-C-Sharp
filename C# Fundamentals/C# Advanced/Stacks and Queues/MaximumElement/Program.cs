using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var stack = new Stack<long>();
            var maxNums = new Stack<long>();
            var max = long.MinValue;

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ');

                if (input.Length == 2)
                {
                    var digit = long.Parse(input[1]);
                    stack.Push(digit);
                    if (digit > max)
                    {
                        max = digit;
                        maxNums.Push(digit);
                    }
                }
                else if (input[0] == "2")
                {
                    if (stack.Pop() == max)
                    {
                        maxNums.Pop();
                        if (maxNums.Count != 0)
                        {
                            max = maxNums.Peek();
                        }
                        else
                        {
                            max = long.MinValue;
                        }
                    }
                }
                else
                {
                    Console.WriteLine(max);
                }
            }
        }
    }
}
