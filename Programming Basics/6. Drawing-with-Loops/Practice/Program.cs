using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {

            var n = int.Parse(Console.ReadLine());
            int empty;var space = 0;

            for (int top = 1; top <= n; top++)
            {
                for (empty = 1; empty <= n-top; empty++)
                {
                    Console.Write(' ');
                }
                if (top == 1) Console.WriteLine('*');
                else if(top!=0) Console.Write('*');
                if (top > 1)
                {
                    for (int starr =1; starr <=n-empty ; starr++)
                    {
                        Console.Write(" *");
                    }
                    Console.WriteLine();
                }
            }
            for (int bot = 1; bot <= n-1; bot++)
            {   if (bot > 1)
                {
                    for (int a = 1; a <=space; a++)
                    {
                        Console.Write(' ');
                    }
                }
                for (int star = 1; star <= n - bot; star++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
                space++;
                
            }


        }
    }
}
