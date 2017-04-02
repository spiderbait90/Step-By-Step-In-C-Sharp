using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Check_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var prime = true;
            if (n < 2) Console.WriteLine("Not prime");
            else
            {
                for (var i = 2; i <= Math.Sqrt(n); i++)
                    if (n % i == 0)
                    {
                        prime = false;
                        break;
                    }
            }
            if (prime==true) Console.WriteLine("Prime");
            else Console.WriteLine("Not prime");
        }
        }
}
