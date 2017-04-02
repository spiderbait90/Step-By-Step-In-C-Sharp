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
            var n1 = int.Parse(Console.ReadLine());
            var n2 = int.Parse(Console.ReadLine());
            var n3 = int.Parse(Console.ReadLine());          
            
            if (n1 + n2 == n3)
                Console.WriteLine("{0} + {1} = {2}", Math.Min(n1,n2), Math.Max(n1, n2), n3);       
            
            else if (n1 + n3 == n2)
                Console.WriteLine("{0} + {1} = {2}", Math.Min(n1, n3), Math.Max(n1, n3), n2);
           
            else if (n2 + n3 == n1)
                Console.WriteLine("{0} + {1} = {2}", Math.Min(n2, n3), Math.Max(n2, n3), n1);
            else
                Console.WriteLine("no");






        }
    }
}
