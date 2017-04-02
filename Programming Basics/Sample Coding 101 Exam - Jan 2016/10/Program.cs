using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var wide = n * 2;

            Console.WriteLine(new string ('%',wide));
            if (n % 2 != 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    Console.Write("%");  
                    if (i==(n/2)+1 )
                    {
                        Console.Write(new string(' ', wide - n - 2));
                        Console.Write("**");
                        Console.Write(new string(' ', wide - n - 2));
                    }
                    else             
                     Console.Write(new string(' ', wide - 2));
                    Console.WriteLine("%");
                }
            }
            else if(n%2==0)
            {
                for (int i = 1; i <= n-1; i++)
                {
                    Console.Write("%");
                    if (i == n / 2)
                    {
                        Console.Write(new string(' ', wide-n-2));
                        Console.Write("**");
                        Console.Write(new string(' ', wide-n-2));
                    }
                    else Console.Write(new string(' ', wide - 2));
                    Console.WriteLine("%");
                }
            }
            Console.WriteLine(new string('%', wide));

        }
    }
}
