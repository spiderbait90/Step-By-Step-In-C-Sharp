using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Невалидно_число
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            /// var InRange = num >= 100 && num <= 200 || num == 0;
            /// if (!InRange) 
            if (!(num >= 100 && num <= 200 || num == 0))                  
            Console.WriteLine("invalid");
            


            
            
        }
    }
}
