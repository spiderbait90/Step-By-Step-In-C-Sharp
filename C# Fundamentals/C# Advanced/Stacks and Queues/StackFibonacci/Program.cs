using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());
            var stack = new Stack<long>();
            stack.Push(0);
            var first = stack.Peek();

            stack.Push(1);
            var second = stack.Peek();

            for (int i = 0; i < n - 1; i++)
            {
                stack.Push(first + second);

                first = second;
                second = stack.Peek();
            }

            Console.WriteLine(stack.Peek());
        }
    }
}
