using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var p = int.Parse(Console.ReadLine());

            var courses =(int)Math.Ceiling((double)n / p);
            Console.WriteLine(courses);
        }
    }
}
