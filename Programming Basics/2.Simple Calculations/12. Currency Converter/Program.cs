using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Currency_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            var amount = double.Parse(Console.ReadLine());
            string firstCurrency = Console.ReadLine().ToLower();
            string secondCurrency = Console.ReadLine().ToLower();
            if (firstCurrency == "usd") amount *= 1.79549;
            else if (firstCurrency == "eur") amount *= 1.95583;
            else if (firstCurrency == "gbp") amount *= 2.53405;
            if (secondCurrency == "usd") amount /= 1.79549;
            else if (secondCurrency == "eur") amount /= 1.95583;
            else if (secondCurrency == "gbp") amount /= 2.53405;
            Console.WriteLine(Math.Round(amount, 2));




        }
    }
}
