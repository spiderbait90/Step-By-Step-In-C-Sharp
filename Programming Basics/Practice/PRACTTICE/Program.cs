using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTTICE
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int sum = 0;var digit = 0;

            while(n!=0)
            {
                digit = n % 10;
                n = n / 10;
                sum += digit;                

            }
            Console.WriteLine(sum);
            
                
            }
        }
    }

