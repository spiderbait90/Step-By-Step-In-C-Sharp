using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Winning_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            var tickets = Console.ReadLine()
                .Split(new[] { ',', ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim()).ToList();

            var check = @"([@#$^])\1{5,}";
            var list = new List<string>();

            foreach (var ticket in tickets)
            {
                if (ticket.Length != 20)
                    list.Add("invalid ticket");

                else
                {
                    var firstHalf = string.Join("", ticket.Take(10));
                    var secondHalf = string.Join("", ticket.Skip(10));
                    var firstMatch = Regex.Match(firstHalf, check).ToString();
                    var secondMatch = Regex.Match(secondHalf, check).ToString();

                    if (firstMatch.Length < 6 || secondMatch.Length<6)
                        list.Add($"ticket \"{ticket}\" - no match");
                    else
                    {
                        if (firstMatch.Length + secondMatch.Length == 20)
                            list.Add($"ticket \"{ticket}\" - {firstMatch.Length}{firstMatch[0]} Jackpot!");

                        else
                        {
                            if (secondMatch.Length < firstMatch.Length)
                                list.Add($"ticket \"{ticket}\" - {secondMatch.Length}{firstMatch[0]}");
                            else
                                list.Add($"ticket \"{ticket}\" - {firstMatch.Length}{firstMatch[0]}");
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine, list));
            
        }
    }
}
