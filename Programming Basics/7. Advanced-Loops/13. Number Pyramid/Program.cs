using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var pyramid = 1;           
            
            for (int i =1; i <= n; i++)
            {
                
                for (int a = 1; a <= i; a++)
                {
                    if (a > 1) Console.Write(" ");
                    Console.Write(pyramid);
                    pyramid++;
                    if (pyramid > n) break;
                }
                Console.WriteLine();
                if (pyramid > n) break;
            }
            
        }
    }
}
