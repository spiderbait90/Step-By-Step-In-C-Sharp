using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Min_Method
{
    class Program
    {
        public static void Main(string[] args)
        {
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            var num3 = int.Parse(Console.ReadLine());
            var min = GetMin(num1, num2);
            if (min < num3) Console.WriteLine(min);
            else if (min > num3) Console.WriteLine(num3);
        }
        public static int GetMin(int a,int b)
        {            
            if (a<b)
            {
                return a;
            }
            else if (a > b)
            {
                return b;
            }
            return 1;
        }
    }
}
