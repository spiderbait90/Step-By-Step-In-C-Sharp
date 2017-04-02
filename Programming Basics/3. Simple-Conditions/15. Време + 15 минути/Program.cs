using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Време___15_минути
{
    class Program
    {
        static void Main(string[] args)
        {
            var hour = int.Parse(Console.ReadLine());
            var min = int.Parse(Console.ReadLine());

            var sum = (hour * 60) + min+15;
            hour = sum / 60;
            min = sum % 60;
            if (hour >= 24)
            
                hour -= 24;
            if (min < 10)
                Console.WriteLine("{0}:0{1}", hour, min);
            else
                Console.WriteLine("{0}:{1}", hour, min);

        }
    }
}
