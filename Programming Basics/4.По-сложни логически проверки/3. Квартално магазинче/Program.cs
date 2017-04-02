using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Квартално_магазинче
{
    class Program
    {
        static void Main(string[] args)
        {
            var Product = Console.ReadLine().ToLower();
            var City = Console.ReadLine().ToLower();
            var Quantity = double.Parse(Console.ReadLine());
            if(City=="sofia")
            {
                if(Product=="coffee")   Console.WriteLine(Quantity * 0.50);
                else if (Product == "water")   Console.WriteLine(Quantity * 0.80);
                else if (Product == "beer")     Console.WriteLine(Quantity * 1.20);
                else if (Product == "sweets")   Console.WriteLine(Quantity * 1.45);
                else if (Product == "peanuts")  Console.WriteLine(Quantity * 1.60);
            }
            else if (City == "plovdiv")
            {
                if (Product == "coffee") Console.WriteLine(Quantity * 0.40);
                else if (Product == "water") Console.WriteLine(Quantity * 0.70);
                else if (Product == "beer") Console.WriteLine(Quantity * 1.15);
                else if (Product == "sweets") Console.WriteLine(Quantity * 1.30);
                else if (Product == "peanuts") Console.WriteLine(Quantity * 1.50);
            }
            else if (City == "varna")
            {
                 if (Product == "coffee") Console.WriteLine(Quantity * 0.45);
                else if (Product == "water") Console.WriteLine(Quantity * 0.70);
                else if (Product == "beer") Console.WriteLine(Quantity * 1.10);
                else if (Product == "sweets") Console.WriteLine(Quantity * 1.35);
                else if (Product == "peanuts") Console.WriteLine(Quantity * 1.55);
                
            }
        }
    }
}
