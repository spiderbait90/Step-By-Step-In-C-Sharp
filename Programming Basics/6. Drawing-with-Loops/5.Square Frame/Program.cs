using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Square_Frame
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Console.Write("+");
            for (int top = 0; top < n-2; top++)
            {
                Console.Write(" -");
            }
            Console.WriteLine(" +");
           
            for (int mid = 0; mid < n-2; mid++)
            {
                Console.Write("|");
                for (int mid2 = 0; mid2 < n-2; mid2++)
                {
                    Console.Write(" -");
                }
                Console.WriteLine(" |");                
            }
            
            Console.Write('+');
            for (int bot = 0; bot < n-2; bot++)
            {
                Console.Write(" -");
            }
            Console.WriteLine(" +");
        }
    }
}
