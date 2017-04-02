using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            bool lamp = false;
            for (int i = 1; i <= n; i++)
            {
                var sum = i % 10 + i / 10;
                lamp = (sum == 5 || sum == 7 || sum == 11);
                Console.WriteLine($"{i} -> {lamp}");

            }
        }
    }
}
