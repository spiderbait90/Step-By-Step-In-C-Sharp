using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Sum_Array_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var numbers = new int[n];
            var sum = 0;
            for (int i = 0; i < n; i++)
            {
                var currentnum = int.Parse(Console.ReadLine());
                numbers[i] = currentnum;
                sum += numbers[i];
            }
            Console.WriteLine(sum);
        }
    }
}
