using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Triangle_of_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int Column = 1; Column<=n; Column++)
            {
                
                for (int rows = 1; rows <= Column; rows++)
                {
                    Console.Write("$ ");
                }
                Console.WriteLine();
            }
            
           
        }
    }
}
