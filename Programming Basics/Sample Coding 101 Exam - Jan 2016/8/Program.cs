using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var count = 1;
            var previous = 1;
            var bigger = int.MinValue;

            for (int i = 1; i <= n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (i == 1)
                {
                    bigger = num;
                    
                }
                else if (num>bigger)
                {
                    bigger = num;
                    count++;
                }

                else if (num <= bigger)
                {
                    bigger = num;
                    if (count > previous) previous = count;                 
                    count = 1;
                }
            }
            if (count > previous) previous = count;
            Console.WriteLine(previous);   
        }
    }
}
