using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._5_Different_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            var check = false;
            for (int a = num1; a <= num2; a++)
            {
                for (int b = num1; b <= num2; b++)
                {
                    for (int c = num1; c <= num2; c++)
                    {
                        for (int d = num1; d <= num2; d++)
                        {
                            for (int e = num1; e <= num2; e++)
                            {
                                if (num1 <= a && a < b && b < c && c < d && d < e && e <= num2)
                                {
                                    Console.WriteLine($"{a} {b} {c} {d} {e}");
                                    check = true;
                                }
                            }
                        }
                    }
                }
            }
            if(check==false)
                Console.WriteLine("No");
        }
    }
}
