using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var count = 0;string result="";
            for (int i = a; i <= b; i++)
            {
                for (int ii = a; ii <= b; ii++)
                {
                    for (int iii = a; iii <= b; iii++)
                    {
                        for (int iiii = a; iiii <= b; iiii++)
                        {
                            if (i < ii && ii < iii && iii < iiii)
                            {
                                ///Console.WriteLine($"{i} {ii} {iii} {iiii}");
                                result += $"{i}" + " " + $"{ii}" + " " + $"{iii}" + " " + $"{iiii} ";
                            }
                            else count++;
                        }
                    }
                }
            }
            ///var asd = (Math.Max(a, b) - Math.Min(a, b)+1);
            ///asd = asd * asd * asd * asd;
            ///if (count ==asd) Console.WriteLine("no");
            Console.WriteLine(result);
        }
    }
}
