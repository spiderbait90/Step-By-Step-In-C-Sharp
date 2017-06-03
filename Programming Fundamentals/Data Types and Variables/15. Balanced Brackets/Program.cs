using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Balanced_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var lastBracket = "";
            for (int i = 1; i <= n; i++)
            {
                var str = Console.ReadLine();              

                if (lastBracket == "")
                {
                    if (str == "(")
                    {
                        lastBracket = "(";
                    }
                    else if (str == ")")
                    {
                        Console.WriteLine("UNBALANCED");
                        return;
                    }                    
                }
                else if (lastBracket != str)
                {
                    if (str == ")" || str == "(")
                        lastBracket = str;
                }
                else if (lastBracket == str)
                {
                    Console.WriteLine("UNBALANCED");
                    return;
                }
                if (lastBracket == "(" && i == n)
                {
                    Console.WriteLine("UNBALANCED");
                    return;
                }
            }
            Console.WriteLine("BALANCED");
        }
    }
}
