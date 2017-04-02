using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __3.Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            PrintTop(n);
            PrintLine(1,n);
            PrintBot(n);
        }
        static void PrintLine(int begin,int stop)
        {
            for (int i = begin; i <= stop; i++)
            {
                Console.Write(i+" ");                
            }
            Console.WriteLine();
        }
        static void PrintTop(int n)
        {
            for (int i = 1; i <= n-1; i++)
            {
                PrintLine(1, i);
            }            
        }
        static void PrintBot(int n)
        {
            for (int i = n-1; i >= 1; i--)
            {
                PrintLine(1, i);
            }
        }
        


    }
}
