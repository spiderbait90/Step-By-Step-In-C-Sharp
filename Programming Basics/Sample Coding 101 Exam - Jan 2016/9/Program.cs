using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var space = n-1;
            var bot = n - 1;
            for (int i = 1; i <=n; i++)
            {
                Console.Write(new string(' ',space));
                for (int a = 1; a <= i; a++)
                {
                    if (i==1)Console.Write('*');
                    else
                    {
                        if (a==1)Console.Write("*");
                        else Console.Write("-*");
                    }
                }
                Console.WriteLine();
                space--;
            }
            space += 2;
            for (int i = bot; i >=1; i--)
            {
                Console.Write(new string(' ', space));
                for (int a = 1; a<=i ; a++)
                {
                    if (a == 1)
                     Console.Write("*");
                    else
                    {
                        
                        Console.Write("-*");
                    }                   
                                    
                                     
                             
                   
                }
                space++;
                Console.WriteLine();
            }
        }
    }
}
