using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practiceee
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 0;var diff = 0;

            for (int i = 1; i <= n; i++)
            {
                var num1 = int.Parse(Console.ReadLine());
                var num2 = int.Parse(Console.ReadLine());
                var tempsum = num1 + num2;
                if(i==1)
                {
                    sum = tempsum;
                }
                else
                {
                    if (sum!=tempsum)
                    {
                        var tempdiff = Math.Abs(sum - tempsum);
                        if (tempdiff > diff) diff = tempdiff;
                        sum = tempsum;
                    }
                }

            }
            if (diff == 0) Console.WriteLine($"Yes, value={sum}");
            else if (diff != 0) Console.WriteLine($"No, maxdiff={diff}");
            
        }

    }
        
    }

