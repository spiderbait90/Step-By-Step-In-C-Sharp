using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Date { get; set; }
    }
    public class Town
    {
        public string Name { get; set; }
        public int SeatsCount { get; set; }
        public List<Student> Students { get; set; }
    }
    public class Group
    {
        public Town Town { get; set; }
        public List<Student> Students { get; set; }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            var towns = new Dictionary<string, Town>();
            var input = Console.ReadLine();
            while (true)
            {
                if (input == "End")
                    break;
                There:
                var townSeatsSplit = input
                    .Split(new[] { '=', '>' },
                    StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => x.Trim())
                    .ToArray();
                var townName = townSeatsSplit[0];
                var seatsCount = int.Parse(townSeatsSplit[1].Split()
                    .First());
                var currTown = new Town();
                currTown.Name = townName;
                currTown.SeatsCount = seatsCount;
                currTown.Students = new List<Student>();

                input = Console.ReadLine();
                while (true)
                {
                    var userInfo = input
                        .Split(new[] { '|' }
                        , StringSplitOptions.RemoveEmptyEntries)
                        .Select(x => x.Trim())
                        .ToArray();
                    var studentName = userInfo[0];
                    var email = userInfo[1];
                    var date = userInfo[2];
                    var currStudent = new Student();
                    currStudent.Name = studentName;
                    currStudent.Email = email;
                    currStudent.Date = DateTime.ParseExact
                        (date, @"d-MMM-yyyy", CultureInfo.InvariantCulture);
                    currTown.Students.Add(currStudent);
                    if (!towns.ContainsKey(currTown.Name))
                        towns[currTown.Name] = currTown;
                    input = Console.ReadLine();
                    if (input == "End")
                        goto Here;
                    if (input.Contains("=>"))
                        goto There;
                }
            }
            Here:;
            var groups = new List<Group>();
            foreach (var town in towns.OrderBy(x => x.Key))
            {
                town.Value.Students =
                    town.Value.Students.OrderBy(x => x.Date)
                    .ThenBy(x => x.Name)
                    .ThenBy(x => x.Email)
                    .ToList();
                while (town.Value.Students.Any())
                {
                    var group = new Group();
                    group.Town = town.Value;
                    group.Students = town.Value.Students
                        .Take(group.Town.SeatsCount)
                        .ToList();
                    town.Value.Students = town.Value.Students
                        .Skip(group.Town.SeatsCount)
                        .ToList();
                    groups.Add(group);
                }

            }
            Console.WriteLine($"Created {groups.Count} groups in {towns.Count} towns:");
            foreach (var group in groups.OrderBy(x => x.Town.Name))
            {
                Console.WriteLine($"{group.Town.Name} => " +
                    $"{string.Join(", ", group.Students.Select(x => x.Email))}");

            }
        }
    }
}
