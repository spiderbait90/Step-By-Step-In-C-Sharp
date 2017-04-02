using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            var bricks = int.Parse(Console.ReadLine());
            var workers = int.Parse(Console.ReadLine());
            var wheel = int.Parse(Console.ReadLine());
                        
            double sum = workers * wheel;            
            double total = bricks / sum;
            
            
            Console.WriteLine(Math.Ceiling(total));
        }
    }
}
