using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int total = 0;  bool lamp= false;
            for (int i = 1; i <= n; i++)
            {
                var num = i;
                while (i > 0)
                {
                    total += i % 10;
                    i = i / 10;
                }
                lamp = (total == 5) || (total == 7) || (total == 11);
                Console.WriteLine($"{num} -> {lamp}");
                total = 0;
                i = num;
            }


        }
    }
}
