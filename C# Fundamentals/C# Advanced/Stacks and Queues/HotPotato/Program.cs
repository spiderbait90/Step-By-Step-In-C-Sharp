using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotPotato
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var names = Console.ReadLine().Split();
            var n = int.Parse(Console.ReadLine());
            var qoue = new Queue<string>(names);
            var cycles = 0;

            while (qoue.Count > 1)
            {
                for (int i = 1; i < n; i++)
                {
                    qoue.Enqueue(qoue.Dequeue());
                }
                cycles++;
                var isPrime = true;
                for (int i = 2; i < cycles; i++)
                {
                    if (cycles % i == 0)
                        isPrime = false;
                }
                if (!isPrime || cycles == 1)
                    Console.WriteLine($"Removed {qoue.Dequeue()}");
                else
                {
                    Console.WriteLine($"Prime {qoue.Peek()}");
                }
            }
            Console.WriteLine($"Last is {qoue.Dequeue()}");
        }
    }
}
