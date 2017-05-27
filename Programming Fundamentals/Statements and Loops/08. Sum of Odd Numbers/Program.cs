using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var count = 1;
            var sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += count;
                Console.WriteLine(count);
                count += 2;                
            }
            Console.WriteLine("Sum: {0}",sum);
        }
    }
}
