using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __Increment_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            byte a = 0;var count = 0;
            for (int i = 1; i <= n; i++)
            {
                a++;
                if (a == 0) count++;
            }
            Console.WriteLine(a);
            if (count > 0) Console.WriteLine($"Overflowed {count} times");
            
        }
    }
}
