using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());
            var m = long.Parse(Console.ReadLine());
            var y = long.Parse(Console.ReadLine());
            long count = 0;
            var nOriginal = n;
            while (n>=m)
            {
                count++;
                n -= m;
                if (n==(nOriginal*0.50))
                {
                    try
                    {
                        n /= y;
                    }
                    catch 
                    {
                        continue;                        
                    }                                       
                }                
            }
            Console.WriteLine($"{n}");
            Console.WriteLine($"{count}");
        }
    }
}
