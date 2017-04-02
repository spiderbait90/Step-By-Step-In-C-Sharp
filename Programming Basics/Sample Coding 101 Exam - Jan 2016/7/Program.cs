using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int sum1=0;int sum2=0;int sum3=0;
            var i1 = 0; var i2 = 0; var i3 = 0;
            for (int i = 1; i <=n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (i == 1 || i == i1 + 3)
                {
                    sum1 += num;
                    i1 = i;
                }
                else if (i == 2 || i == i2 + 3)
                {
                    sum2 += num;
                    i2 = i;
                }
                else if (i == 3 || i== i3 + 3)
                {
                    sum3 += num;
                    i3 = i;
                }
                
            }
            Console.WriteLine("sum1 = {0}",sum1);
            Console.WriteLine("sum2 = {0}", sum2);
            Console.WriteLine("sum3 = {0}", sum3);
        }
    }
}
