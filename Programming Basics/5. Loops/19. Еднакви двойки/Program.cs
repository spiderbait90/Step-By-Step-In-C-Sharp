using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Еднакви_двойки
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var max = int.MinValue; var min = int.MaxValue;var PrevSum = 0; var diff = int.MinValue;
            for (int i = 1; i <= n; i++)  
            {
                var num = int.Parse(Console.ReadLine());
                var num2 = int.Parse(Console.ReadLine());
                var currentsum = num2 + num;
                var currentdiff = currentsum - PrevSum;
                if (i!=1)
                {
                    if (Math.Abs(currentsum-PrevSum)!=0&& Math.Abs(currentsum - PrevSum) > diff)
                    {
                        diff = Math.Abs(currentsum - PrevSum);
                    }
                }
                if (currentsum > max) max = currentsum;
                if (currentsum < min) min = currentsum;
                PrevSum = currentsum;
            }
            if (max == min) Console.WriteLine($"Yes, value = {max}");
            else if (max != min) 
                Console.WriteLine("No, maxdiff = {0}",diff);
        }
        
    }
}
