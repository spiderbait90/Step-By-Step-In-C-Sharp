using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Генератор_за_тъпи_пароли
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var L = int.Parse(Console.ReadLine());

            for (int a = 1; a < N; a++)
            {
                for (int b = 1; b < N; b++)
                {
                    for (var c = 'a'; c <'a'+ L; c++)
                    {
                        for (var d = 'a'; d < 'a'+L; d++)
                        {
                            for (int e = Math.Max(a,b)+1; e <= N; e++)
                            {
                                Console.Write("{0}{1}{2}{3}{4} ",a,b,c,d,e);
                            }
                        }
                    }
                }
            }
            Console.WriteLine();

            
           
            
        }
    }
}
