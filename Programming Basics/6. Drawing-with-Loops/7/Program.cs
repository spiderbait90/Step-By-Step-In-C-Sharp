using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            /* var n = int.Parse(Console.ReadLine());
             for (int i = 0; i <= n; i++)
             {
                 var space = new string(' ', n - i);
                 var star = new string('*', i);
                 Console.Write(space);
                 Console.Write(star);
                 Console.Write(" | ");
                 Console.Write(star);                
                 Console.WriteLine(space);
             }
             */
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                for (int a = 0; a < n-i; a++)
                {
                    Console.Write(" ");
                }
                for (int a = 0; a < i; a++)
                {
                    Console.Write("*");
                }
                Console.Write(" | ");
                for (int a = 0; a < i; a++)
                {
                    Console.Write("*");
                }
                for (int a = 0; a < n - i; a++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            
        }
    }
}
