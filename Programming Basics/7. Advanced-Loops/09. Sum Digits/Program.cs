using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int sum = 0;
            while(n!=0)
            {
                var digit = (n % 10);
                n = n / 10;
                sum += digit;
            }
            Console.WriteLine(sum);
            
        }
    }
}
