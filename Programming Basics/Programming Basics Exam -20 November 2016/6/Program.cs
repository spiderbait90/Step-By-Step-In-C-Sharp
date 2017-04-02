using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            var pokemon = int.Parse(Console.ReadLine());
            var pokemon2 = int.Parse(Console.ReadLine());
            var max = int.Parse(Console.ReadLine());
            var count=0;

            for (int a = 1; a <= pokemon2; a++)
            {
                for (int b = 1; b <= pokemon2; b++)
                {
                    count++;
                    Console.Write("({0} <-> {1}) ", a,b);
                    
                    if(count>=max)
                    {
                        Console.WriteLine();
                        return;
                    }
                   
                }
                
            }
            Console.WriteLine();


        }
    }
}
