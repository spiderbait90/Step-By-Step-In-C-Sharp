using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Hands_of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<string, int>();

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "JOKER")
                    break;

                var splitedInput = input.Split(':');
                var name = splitedInput[0];
                var cards = splitedInput[1].Split(new[] { ' ', ',' },
                    StringSplitOptions.RemoveEmptyEntries)
                    .Distinct().ToArray();

                if (!data.ContainsKey(name))
                    data[name] = new int();

                foreach (var card in cards)
                {
                    var checkP = card.First().ToString();
                    var checkT = card.Last().ToString();
                    int p = 0;
                    int t = 0;

                    if (checkP == "J")
                        p = 11;
                    else if (checkP == "Q")
                        p = 12;
                    else if (checkP == "K")
                        p = 13;
                    else if (checkP == "A")
                        p = 14;
                    else if (checkP == "1")
                        p = 10;
                    else
                        p = int.Parse(checkP);

                    if (checkT == "S")
                        t = 4;
                    else if (checkT == "H")
                        t = 3;
                    else if (checkT == "D")
                        t = 2;
                    else if (checkT == "C")
                        t = 1;

                    data[name] += (p * t);
                }
            }
            foreach (var item in data)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
