using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Билети_за_мач
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var category = Console.ReadLine().ToLower();
            var peopple = double.Parse(Console.ReadLine());
            if (peopple>=1&&peopple<5)
            {
                var result = budget - (budget*75/100);
                if (category=="normal")
                {
                    var result1 = 249.99 * peopple;
                    if (result1 < result) Console.WriteLine($"Yes! You have {result - result1:f2} leva left.");
                    else if (result1 > result) Console.WriteLine($"Not enough money! You need {result1-result:f2} leva.");
                }
                else if (category == "vip")
                {
                    var result1 = 499.99 * peopple;
                    if (result1 < result) Console.WriteLine($"Yes! You have {result - result1:f2} leva left.");
                    else if (result1 > result) Console.WriteLine($"Not enough money! You need {result1 - result:f2} leva.");
                }

            }   
            else if (peopple > 4 && peopple < 10)
            {
                var result = budget - (budget * 60 / 100);
                if (category == "normal")
                {
                    var result1 = 249.99 * peopple;
                    if (result1 < result) Console.WriteLine($"Yes! You have {result - result1:f2} leva left.");
                    else if (result1 > result) Console.WriteLine($"Not enough money! You need {result1 - result:f2} leva.");
                }
                else if (category == "vip")
                {
                    var result1 = 499.99 * peopple;
                    if (result1 < result) Console.WriteLine($"Yes! You have {result - result1:f2} leva left.");
                    else if (result1 > result) Console.WriteLine($"Not enough money! You need {result1 - result:f2} leva.");
                }
            }
            else if (peopple > 9 && peopple < 25)
            {
                var result = budget - (budget*50/100);
                if (category == "normal")
                {
                    var result1 = 249.99 * peopple;
                    if (result1 < result) Console.WriteLine($"Yes! You have {result - result1:f2} leva left.");
                    else if (result1 > result) Console.WriteLine($"Not enough money! You need {result1 - result:f2} leva.");
                }
                else if (category == "vip")
                {
                    var result1 = 499.99 * peopple;
                    if (result1 < result) Console.WriteLine($"Yes! You have {result - result1:f2} leva left.");
                    else if (result1 > result) Console.WriteLine($"Not enough money! You need {result1 - result:f2} leva.");
                }
            }
            else if (peopple > 24 && peopple < 50)
            {
                var result = budget - (budget*40/100);
                if (category == "normal")
                {
                    var result1 = 249.99 * peopple;
                    if (result1 < result) Console.WriteLine($"Yes! You have {result - result1:f2} leva left.");
                    else if (result1 > result) Console.WriteLine($"Not enough money! You need {result1 - result:f2} leva.");
                }
                else if (category == "vip")
                {
                    var result1 = 499.99 * peopple;
                    if (result1 < result) Console.WriteLine($"Yes! You have {result - result1:f2} leva left.");
                    else if (result1 > result) Console.WriteLine($"Not enough money! You need {result1 - result:f2} leva.");
                }
            }
            else if (peopple > 49)
            {
                var result = budget - (budget*25/100);
                if (category == "normal")
                {
                    var result1 = 249.99 * peopple;
                    if (result1 < result) Console.WriteLine($"Yes! You have {result - result1:f2} leva left.");
                    else if (result1 > result) Console.WriteLine($"Not enough money! You need {result1 - result:f2} leva.");
                }
                else if (category == "vip")
                {
                    var result1 = 499.99 * peopple;
                    if (result1 < result) Console.WriteLine($"Yes! You have {result - result1:f2} leva left.");
                    else if (result1 > result) Console.WriteLine($"Not enough money! You need {result1 - result:f2} leva.");
                }
            }
        }
    }
}
