using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());
            var sum = 0.0;
            var Biggest = 0.0;
            

            for (int i =0;i< n;i++)
            {
                var num = int.Parse(Console.ReadLine());
                sum =sum+ num;
                if (num > Biggest) Biggest = num;         

            }
            sum =Math.Abs(sum- Biggest);
            if (Biggest == sum) Console.WriteLine("Yes,sum = "+Biggest);
            else Console.WriteLine("No,diff = " + Math.Abs(sum - Biggest));


        }
    }
}
