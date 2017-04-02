using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Number_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int red = 0; red <n; red++)
            {
                for (int colona = 0; colona < n; colona++)
                {
                    var num = red + colona + 1;
                    if (num > n) num = 2 * n - num;
                    Console.Write(num+" ");
                }
                Console.WriteLine();
            }
        }
    }

}
