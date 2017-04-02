using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Търговски_комисионни
{
    class Program
    {
        static void Main(string[] args)
        {
            var city = Console.ReadLine().ToLower();
            var sales = double.Parse(Console.ReadLine());
            if (city == "sofia")
            {
                if (0 <= sales && sales <= 500) Console.WriteLine(sales * 0.05);
                else if (500 <= sales && sales <= 1000) Console.WriteLine(sales * 0.07);
                else if (1000 < sales && sales <= 10000) Console.WriteLine(sales * 0.08);
                else if (10000 < sales) Console.WriteLine(sales * 0.12);
                else Console.WriteLine("error");
            }
            else if (city == "varna")
            {
                if (0 <= sales && sales <= 500) Console.WriteLine(sales * 0.045);
                else if (500 <= sales && sales <= 1000) Console.WriteLine(sales * 0.075);
                else if (1000 < sales && sales <= 10000) Console.WriteLine(sales * 0.10);
                else if (10000 < sales) Console.WriteLine(sales * 0.13);
                else Console.WriteLine("error");
            }
            else if (city == "plovdiv")
            {
                if (0 <= sales && sales <= 500) Console.WriteLine(sales * 0.055);
                else if (500 <= sales && sales <= 1000) Console.WriteLine(sales * 0.08);
                else if (1000 < sales && sales <= 10000) Console.WriteLine(sales * 0.12);
                else if (10000 < sales) Console.WriteLine(sales * 0.145);
                else Console.WriteLine("error");
            }
            else Console.WriteLine("error");
        }
    }
}
