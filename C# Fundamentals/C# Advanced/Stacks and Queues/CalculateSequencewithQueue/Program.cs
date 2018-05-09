using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateSequencewithQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());
            var cycle = new Queue<long>();
            var nums = new List<long>();

            cycle.Enqueue(n);
            nums.Add(n);

            while (nums.Count < 50)
            {
                var s1 = cycle.Dequeue();
                cycle.Enqueue(s1 + 1);
                nums.Add(s1 + 1);
                cycle.Enqueue(2 * s1 + 1);
                nums.Add(2 * s1 + 1);
                cycle.Enqueue(s1 + 2);
                nums.Add(s1 + 2);
            }
            Console.WriteLine(string.Join(" ",nums.Take(50)));
        }
    }
}
