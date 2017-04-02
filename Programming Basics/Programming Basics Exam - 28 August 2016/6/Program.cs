using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
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

            var countred = 0;
            var countnum = 0;
            while (true)
            {
                countnum++;
                if (n % 5 == 0) n -= digit1;
                else if (n % 3 == 0) n -= digit2;
                else n += digit3;
                if (countnum < digit1 + digit3) Console.Write(n+" ");
                else
                {
                    
                    countnum = 0;                    
                    countred++;
                    Console.WriteLine(n);
                    if (countred == digit1 + digit2)
                    {
                        
                        break;
                    }

                }
                
            }

        }
    }
}
