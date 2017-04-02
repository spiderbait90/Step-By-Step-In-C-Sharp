using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());
            double sum1 = 0;
            double sum2 = 0;
            for (int i=0;i<n;i++)
            {
                var num1 = double.Parse(Console.ReadLine());
                sum1 = num1 + sum1;               
            }
            for (int i = 0; i < n; i++)
            {
                var num2 = double.Parse(Console.ReadLine());
                sum2 = num2 + sum2;
            }
            if (sum1==sum2) Console.WriteLine("Yes, sum = " + sum1);
            else if (sum1!=sum2) Console.WriteLine("No, diff = " + Math.Abs(sum1-sum2));
        }
    }
}
