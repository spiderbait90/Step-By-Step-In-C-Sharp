using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Exercises
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var exercises = new List<Exercise>();
            var input = Console.ReadLine();
            while (input!="go go go")
            {
                var split = input.Split(new[] { ' ', '-', '>', ',' }
                , StringSplitOptions.RemoveEmptyEntries);
                
                List<string> problems = split.Skip(3).ToList();

                var currentEx = new Exercise();
                currentEx.Topic = split[0];
                currentEx.CourseName = split[1];
                currentEx.JudgeContestLink = split[2];
                currentEx.Problems = problems;

                exercises.Add(currentEx);
                input = Console.ReadLine();
            }

            foreach (var item in exercises)
            {
                Console.WriteLine($"Exercises: {item.Topic}");
                Console.WriteLine($"Problems for" +
                    $" exercises and homework for the \"{item.CourseName}\"" +
                    $" course @ SoftUni.");
                Console.WriteLine($"Check your solutions here: {item.JudgeContestLink}");
                var count = 1;
                foreach (var problem in item.Problems)
                {
                    Console.WriteLine($"{count}. {problem}");
                    count++;
                }
            }
        }
    }
    public class Exercise
    {
        public string Topic { get; set; }
        public string CourseName { get; set; }
        public string JudgeContestLink { get; set; }
        public List<string> Problems { get; set; }
    }
}
