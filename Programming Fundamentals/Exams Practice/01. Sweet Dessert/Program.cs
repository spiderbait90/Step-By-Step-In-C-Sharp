using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Sweet_Dessert
{
    class Program
    {
        static void Main(string[] args)
        {
            var amountOfCash = double.Parse(Console.ReadLine());
            var numberOfGuests = double.Parse(Console.ReadLine());
            var priceOfBananas = double.Parse(Console.ReadLine());
            var priceOfEggs = double.Parse(Console.ReadLine());
            var priceOfBerries = double.Parse(Console.ReadLine());

            var amountOfPortionrs = Math.Ceiling(numberOfGuests / 6);

            var neededMoney = amountOfPortionrs * (2 * priceOfBananas) +
                amountOfPortionrs * (4 * priceOfEggs) +
                amountOfPortionrs * (0.2 * priceOfBerries);

            if (neededMoney<=amountOfCash)
                Console.WriteLine($"Ivancho has enough money" +
                    $" - it would cost {neededMoney:f2}lv.");
            else if (neededMoney>amountOfCash)
                Console.WriteLine($"Ivancho will have to withdraw money" +
                    $" - he will need {neededMoney-amountOfCash:f2}lv more.");
        }
    }
}
