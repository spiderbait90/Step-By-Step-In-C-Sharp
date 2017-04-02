using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __Fast_Prime_Checker___Refactor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 2; i <= n; i++)
            {
                bool lamp = true;
                for (int i2 = 2; i2 <= Math.Sqrt(i); i2++)
                {
                    if (i % i2 == 0)
                    {
                        lamp = false;
                        break;
                    }
                }
                Console.WriteLine($"{i} -> {lamp}");
            }

        }
    }
}
