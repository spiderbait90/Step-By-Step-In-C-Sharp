using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _66
{
    class Program
    {
        static void Main(string[] args)
        {

            var n = int.Parse(Console.ReadLine());
            var numcopy = n;
            int digit3 = numcopy % 10;
            numcopy /= 10;
            int digit2 = numcopy % 10;
            numcopy /= 10;
            int digit1 = numcopy % 10;

            for (int a = 1; a <= digit1+digit2; a++)
            {
                for (int b = 1; b <= digit1+digit3; b++)
                {
                    if (n % 5 == 0) n -= digit1;
                    else if (n % 3 == 0) n -= digit2;
                    else n += digit3;
                    Console.Write(n+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
