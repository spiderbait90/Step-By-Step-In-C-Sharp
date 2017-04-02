using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Знак_СТОП
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var tall = 2 * n + 2;
            var tochki = n + 1;
            var tireta = 2 * n + 1;

            for (int i = 1; i <= tall-1; i++)
            {
                if (i == 1)
                {
                    Console.Write(new string('.', tochki));
                    Console.Write(new string('_', tireta));
                    Console.WriteLine(new string('.', tochki));
                    tochki--;
                    tireta -= 2;
                }
                else
                {
                    if(i>n+2)
                    {
                        Console.Write(new string('.', tochki));
                        Console.Write("\\\\");
                        Console.Write(new string('_', tireta));
                        Console.Write("//");
                        Console.WriteLine(new string('.', tochki));
                        tireta -= 2;
                        tochki++;
                    }
                    if (i == n + 2)
                    {
                        Console.Write("\\\\");
                        Console.Write(new string('_', tireta));
                        Console.WriteLine("//");
                        tochki++;
                        tireta -= 2;
                    }
                    else if (i<n+2)
                    {
                        Console.Write(new string('.', tochki));
                        Console.Write("//");
                        Console.Write(new string('_', tireta));
                        Console.Write("\\\\");
                        Console.WriteLine(new string('.', tochki));
                        tochki--;
                        tireta += 2;
                    }
                    if (tochki==0)
                    {
                        var newtireta = (tireta - 5)/2;
                        Console.Write("//");
                        Console.Write(new string('_', newtireta));
                        Console.Write("STOP!");
                        Console.Write(new string('_', newtireta));
                        Console.WriteLine("\\\\");
                    }
                }
            }
        }
    }
}
