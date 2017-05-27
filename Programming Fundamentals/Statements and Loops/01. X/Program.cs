using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.X
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var midSpace = n - 2;
            var leftSpace = 0;
            for (int a = 1; a <= n / 2; a++)
            {
                Console.Write(new string(' ',leftSpace));
                Console.Write('x');
                Console.Write(new string(' ', midSpace));                
                Console.WriteLine('x');
                midSpace -= 2;
                leftSpace++;
            }
            Console.Write(new string(' ',n/2));
            Console.WriteLine('x');            
            for (int a = 1; a <= n / 2; a++)
            {
                leftSpace--;
                midSpace += 2;
                Console.Write(new string(' ', leftSpace));
                Console.Write('x');
                Console.Write(new string(' ', midSpace));
                Console.WriteLine('x');                
            }
        }
    }
}
