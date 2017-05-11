using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Football_League
{
    class Program
    {
        static void Main(string[] args)
        {

            var key = Console.ReadLine();
            key = Regex.Escape(key); 
            var regex = new Regex($@".*?{key}(.*?){key}.*?{key}(.*?){key}.*?(\d+):(\d+)");
            var teamPoints = new Dictionary<string, int>();
            var topgoals = new Dictionary<string, int>();

            var input = Console.ReadLine();
            while (input!="final")
            {
                var match = regex.Match(input);
                var team1 = match.Groups[1].ToString().ToUpper().ToCharArray();
                var team2 = match.Groups[2].ToString().ToUpper().ToCharArray();
                Array.Reverse(team1); Array.Reverse(team2);
                var firstTeam = new string(team1);
                var secondTeam = new string(team2);
                var firstGoals = int.Parse(match.Groups[3].ToString());
                var secondGoals = int.Parse(match.Groups[4].ToString());

                if (!teamPoints.ContainsKey(firstTeam))
                    teamPoints[firstTeam] = new int();
                if (!teamPoints.ContainsKey(secondTeam))
                    teamPoints[secondTeam] = new int();

                if (firstGoals>secondGoals)
                {
                    teamPoints[firstTeam] += 3;
                    teamPoints[secondTeam] += 0;
                }
                else if (firstGoals < secondGoals)
                {
                    teamPoints[firstTeam] += 0;
                    teamPoints[secondTeam] += 3;
                }
                else if (firstGoals==secondGoals)
                {
                    teamPoints[firstTeam] += 1;
                    teamPoints[secondTeam] += 1;
                }
                if (!topgoals.ContainsKey(firstTeam))
                    topgoals[firstTeam] = new int();
                if (!topgoals.ContainsKey(secondTeam))
                    topgoals[secondTeam] = new int();
                
                    topgoals[firstTeam] += firstGoals;                
                    topgoals[secondTeam] += secondGoals;

                input = Console.ReadLine();
            }
            var count = 1;
            Console.WriteLine("League standings:");

            foreach (var team in teamPoints.
                OrderByDescending(x=>x.Value)
                .ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{count}. {team.Key} {team.Value}");
                count++;
            }
            Console.WriteLine("Top 3 scored goals:");
            foreach (var team in topgoals
                .OrderByDescending(x=>x.Value)
                .ThenBy(x=>x.Key).Take(3))
            {
                Console.WriteLine($"- {team.Key} -> {team.Value}");
            }
        }
    }
}
