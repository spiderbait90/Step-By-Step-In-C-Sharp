using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Чертане_на_крепост
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var wide = 2 * n;
            var col = n / 2;

            for (int i = 1; i <= n; i++)
            {
                if (i == 1)
                {
                    Console.Write('/');
                    Console.Write(new string('^', col));
                    Console.Write('\\');
                    if (n >= 5) Console.Write(new string('_',wide- (col+col)-4));
                    Console.Write('/');
                    Console.Write(new string('^', col));
                    Console.WriteLine('\\');
                }
                else if (i > 1&&i<n)
                {
                    if (i==n-1)
                    {
                        
                        Console.Write('|');
                        Console.Write(new string(' ', n/2+1));
                        if (n>=5) Console.Write(new string('_', wide - (col + col) - 4));
                        Console.Write(new string(' ', n/2+ 1));
                        Console.WriteLine('|');
                    }
                    else
                    {
                        Console.Write('|');
                        Console.Write(new string(' ', (wide-2)));
                        Console.WriteLine('|');
                    }
                    
                }
                else if (i==n)
                {
                    Console.Write('\\');
                    Console.Write(new string('_', col));
                    Console.Write('/');
                    if (n >= 5) Console.Write(new string(' ', wide - (col + col) - 4));
                    Console.Write('\\');
                    Console.Write(new string('_', col));
                    Console.WriteLine('/');
                }

            }
        }
    }
}
