using System;

namespace _05.Integer_to_Base
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = long.Parse(Console.ReadLine());
            var toBase = int.Parse(Console.ReadLine());
            Console.WriteLine(IntegerToBase(number,toBase));
        }
        static string IntegerToBase(long number,int toBase)
        {
            string result = string.Empty;
            
            while(number>0)
            {
                var remainder = number % toBase;
                result = remainder + result;
                number /= toBase;
            }
            return result;
        }
    }
}
