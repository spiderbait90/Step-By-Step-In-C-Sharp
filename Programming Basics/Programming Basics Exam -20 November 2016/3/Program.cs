using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            var old = double.Parse(Console.ReadLine());
            var students = double.Parse(Console.ReadLine());
            var nights = double.Parse(Console.ReadLine());
            var transport = Console.ReadLine();
            var total = 0.0;
            if (transport=="train")
            {
                total = (old * 24.99 + students * 14.99)*2;
                if (old + students >= 50) total = total / 2;
            }
            else if (transport == "bus")
            {
                total = (old * 32.50 + students * 28.50) * 2;
            }
            else if (transport == "boat")
            {
                total = (old * 42.99 + students * 39.99) * 2;
            }
            else if (transport == "airplane")
            {
                total = (old * 70.00 + students * 50.00) * 2;
            }
            
            var hotel = nights * 82.99;
            var commission = (total + hotel) * 0.10;
            var all = total + hotel + commission;
            Console.WriteLine(Math.Round(all,2));
        }
    }
}
