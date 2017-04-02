using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ___4.Draw_a_Filled_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            TopAndBot(n);
            Mid(n);            
            TopAndBot(n);
        }
        static void TopAndBot(int n)
        {
            Console.WriteLine(new string('-',2*n));
        }
        static void Mid(int n)
        {
            for (int i = 1; i <= n-2; i++)
            {
                Console.Write("-");
                for (int a = 1; a < n; a++)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine("-");
            }
            
        }
    }
}
