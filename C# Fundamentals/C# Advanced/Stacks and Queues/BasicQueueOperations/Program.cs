using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            var commands = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            var digitsToAdd = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            var stack = new Queue<long>();

            for (int i = 0; i < commands[0]; i++)
            {
                stack.Enqueue(digitsToAdd[i]);
            }

            for (int i = 0; i < commands[1]; i++)
            {
                stack.Dequeue();
            }

            if (stack.Count == 0)
                Console.WriteLine(0);
            else if (stack.Contains(commands[2]))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(stack.Min());
            }
        }
    }
}
