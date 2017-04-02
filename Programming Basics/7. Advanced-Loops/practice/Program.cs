using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var n= int.Parse(Console.ReadLine());
            var fact = 1;
            while(n>1)
            {
                fact = fact * n;
                n--;
            }
            Console.WriteLine(fact);
            
            
        }
    }
}
