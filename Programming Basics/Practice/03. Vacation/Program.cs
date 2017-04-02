using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            var old = int.Parse(Console.ReadLine());
            var students = int.Parse(Console.ReadLine());
            var nights = int.Parse(Console.ReadLine());
            var transport = Console.ReadLine();
            double pricetransport=0;

            if (transport=="train")
            {
                pricetransport = ((old * 24.99) + (students * 14.99)) * 2;
                if (old + students >= 50) pricetransport -= (pricetransport * 0.50);

            }
            else if (transport == "bus")
            {
                pricetransport = ((old * 32.50) + (students * 28.50)) * 2;
            }
            else if (transport == "boat")
            {
                pricetransport = ((old * 42.99) + (students * 39.99)) * 2;
            }
            else if (transport == "airplane")
            {
                pricetransport = ((old * 70.00) + (students * 50.00)) * 2;
            }
            double pricehotel = nights * 82.99;
            double commision = (pricehotel + pricetransport) * 0.10;
            double total = pricehotel + pricetransport + commision;

            Console.WriteLine($"{total:f2}");
        }
    }
}
