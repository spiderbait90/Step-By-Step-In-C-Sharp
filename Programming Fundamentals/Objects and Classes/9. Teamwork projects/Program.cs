using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Teamwork_projects
{
    public class Team
    {
        public string TeamName { get; set; }
        public string CreatorName { get; set; }
        public List<string> Users { get; set; }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var teams = new Dictionary<string, Team>();
            var creators = new List<string>();
            var users = new List<string>();

            for (int i = 0; i < n; i++)
            {
                var userAndTeam = Console.ReadLine()
                .Split(new[] { '-' }, StringSplitOptions
                .RemoveEmptyEntries);

                var teamName = userAndTeam[1];
                var userName = userAndTeam[0];

                if (teams.ContainsKey(teamName))
                {
                    Console.WriteLine($"Team {teamName} was " +
                        $"already created!");
                }
                else if (creators.Contains(userName))
                {
                    Console.WriteLine($"{userName} cannot create another team!");
                }
                else
                {
                    var newTeam = new Team();
                    newTeam.TeamName = teamName;
                    newTeam.CreatorName = userName;
                    teams[teamName] = new Team();
                    teams[teamName] = newTeam;
                    creators.Add(userName);

                    Console.WriteLine($"Team {teamName} has " +
                        $"been created by {userName}!");
                }
            }

            var input = Console.ReadLine();
            while (input != "end of assignment")
            {
                var split = input.Split(new[] { '-', '>', }
                , StringSplitOptions.RemoveEmptyEntries);

                var userName = split[0];
                var teamName = split[1];

                if (!teams.ContainsKey(teamName))
                    Console.WriteLine($"Team {teamName} does not exist!");

                else if (users.Contains(userName) ||
                    creators.Contains(userName))
                    Console.WriteLine($"Member {userName} cannot join team {teamName}!");

                else
                {
                    users.Add(userName);
                    if (teams[teamName].Users == null)
                        teams[teamName].Users = new List<string>();
                    teams[teamName].Users.Add(userName);
                }
                input = Console.ReadLine();
            }
            var teamsToDisband = teams.Where(x => x.Value.Users == null)
                .ToDictionary(x => x.Key, y => y.Value);

            foreach (var team in teams
                .Where(x => x.Value.Users != null)
                .OrderByDescending(x => x.Value.Users.Count)
                .ThenBy(x => x.Key))
            {
                Console.WriteLine($"{team.Key}");
                Console.WriteLine($"- {team.Value.CreatorName}");
                foreach (var user in team.Value.Users
                    .OrderBy(x => x))
                {
                    Console.WriteLine($"-- {user}");
                }
            }
            Console.WriteLine("Teams to disband:");
            foreach (var team in teamsToDisband
                .OrderBy(x => x.Key))
            {
                Console.WriteLine($"{team.Key}");
            }
        }
    }
}
