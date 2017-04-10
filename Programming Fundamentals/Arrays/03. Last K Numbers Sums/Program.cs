using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Last_K_Numbers_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var k = int.Parse(Console.ReadLine());
            var array = new int[n];
            array[0] = 1;
            for (int i = 1; i < n; i++)
            {
                for (int a = i-k; a < i-1; a++)
                {
                    array[i] = array[a];
                }
            }
        }
    }
}
