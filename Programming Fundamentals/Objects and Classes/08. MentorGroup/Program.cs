using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MentorGroup
{
    public class User
    {
        public string Name { get; set; }
        public List<DateTime> Dates { get; set; }
        public List<string> Comments { get; set; }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            var inputDates = Console.ReadLine();
            var allUsers = new Dictionary<string, User>();

            while (inputDates != "end of dates")
            {
                var split = inputDates
                    .Split(new[] { ' ', ',' });

                var user = new User();
                user.Name = split[0];
                user.Dates = new List<DateTime>();
                if (split.Length > 1)
                {
                    user.Dates.AddRange
                        (split.Skip(1).Select(x => DateTime.ParseExact
                        (x, @"dd/MM/yyyy", CultureInfo.InvariantCulture)));
                }
                if (!allUsers.ContainsKey(user.Name))
                    allUsers[user.Name] = user;
                else
                {
                    allUsers[user.Name].Dates.AddRange(user.Dates);
                }

                inputDates = Console.ReadLine();
            }
            var inputComments = Console.ReadLine();

            while (inputComments != "end of comments")
            {
                var split = inputComments.Split('-');
                var name = split[0];
                var comment = split[1];

                if (allUsers.ContainsKey(name))
                {
                    if (allUsers[name].Comments == null)
                        allUsers[name].Comments = new List<string>();
                    allUsers[name].Comments.Add(comment);
                }
                inputComments = Console.ReadLine();
            }
            foreach (var user in allUsers.Values
                .OrderBy(x => x.Name))
            {
                Console.WriteLine($"{user.Name}");
                Console.WriteLine($"Comments:");
                if (user.Comments!=null)
                    foreach (var comment in user.Comments)
                    {
                        Console.WriteLine($"- {comment}");
                    }
                Console.WriteLine($"Dates attended:");
                foreach (var date in user.Dates.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {date.ToString(@"dd\/MM\/yyyy")}");
                }
            }
        }
    }
}

