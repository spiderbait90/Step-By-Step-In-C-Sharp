using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Square_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int a = 0; a < n; a++)
            {
                Console.Write("*");
                for (int  b= 1; b <n ; b++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
    }
}
