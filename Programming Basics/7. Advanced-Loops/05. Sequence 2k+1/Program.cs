using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Sequence_2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = 1;
            var n = int.Parse(Console.ReadLine());
            while (num <= n) 
            {
                Console.WriteLine(num);
                num *= 2;
                num++;
            }

           /* for (num = 1; num < n; num=num*2+1)
            {
                Console.WriteLine(num);
            }
            */
        }
    }
}
