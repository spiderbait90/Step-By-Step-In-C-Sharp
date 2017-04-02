using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = decimal.Parse(Console.ReadLine());
            var num2 = decimal.Parse(Console.ReadLine());

            var bigger = Math.Max(num1, num2); string small = "";
            var smaller = Math.Min(num1, num2); string big = "";
            ulong minvalue = 0;
            if (bigger <= byte.MaxValue && bigger >= byte.MinValue)
                big = "byte";
            else if (bigger <= ushort.MaxValue && bigger >= ushort.MinValue)
                big = "ushort";
            else if (bigger <= uint.MaxValue && bigger >= uint.MinValue)
                big = "uint";
            else if (bigger <= ulong.MaxValue && bigger >= ulong.MinValue)
                big = "ulong";
            if (smaller <= byte.MaxValue && smaller >= byte.MinValue)
            {
                small = "byte"; minvalue = byte.MaxValue;
            }
            else if (smaller <= ushort.MaxValue && smaller >= ushort.MinValue)
            {
                small = "ushort"; minvalue = ushort.MaxValue;
            }
            else if (smaller <= uint.MaxValue && smaller >= uint.MinValue)
            {
                small = "uint"; minvalue = uint.MaxValue;
            }
            else if (smaller <= ulong.MaxValue && smaller >= ulong.MinValue)
            {
                small = "ulong"; minvalue = ulong.MaxValue;
            }

            Console.WriteLine($"bigger type: {big}");
            Console.WriteLine($"smaller type: {small}");
            Console.WriteLine($"{bigger} can overflow {small} {Math.Round(bigger / minvalue)} times ");
        }
    }
}
