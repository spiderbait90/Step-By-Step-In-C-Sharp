using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Heists
{
    class Program
    {
        static void Main(string[] args)
        {
            var prices = Console.ReadLine().Split()
                .Select(int.Parse).ToArray();

            var goldPrice = prices[1];
            var jewelsPrice = prices[0];
            var totalEarnings = 0;
            var totalExpenses = 0;

            var input = Console.ReadLine();
            while (input!="Jail Time")
            {
                var splited = input.Split();

                totalExpenses += int.Parse(splited[1]);

                foreach (var item in splited[0])
                {
                    if (item == '$')
                        totalEarnings += goldPrice;
                    else if (item == '%')
                        totalEarnings += jewelsPrice;
                }
                input = Console.ReadLine();
            }

            if (totalEarnings>=totalExpenses)
                Console.WriteLine($"Heists will continue." +
                    $" Total earnings: {totalEarnings-totalExpenses}.");
            else
                Console.WriteLine($"Have to find another job." +
                    $" Lost: {totalExpenses-totalEarnings}.");
        }
    }
}
