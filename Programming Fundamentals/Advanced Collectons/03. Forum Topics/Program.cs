using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Forum_Topics
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var data = new Dictionary<string, HashSet<string>>();

            while (input != "filter")
            {
                var hashTags =
                    input.Split(new[] { ' ', '-', '>', ',' },
                    StringSplitOptions.RemoveEmptyEntries);
                var topic = hashTags[0];

                if (!data.ContainsKey(topic))
                {
                    data[topic] = new HashSet<string>();
                }
                for (int i = 1; i < hashTags.Length; i++)
                {
                    data[topic].Add(hashTags[i]);
                }
                input = Console.ReadLine();
            }
            var tags = Console.ReadLine()
                .Split(new[] { ' ', ',' }
                , StringSplitOptions.RemoveEmptyEntries);
            var check = 0;
            foreach (var topic in data)
            {
                foreach (var tag in tags)
                {
                    if (topic.Value.Contains(tag))
                    {
                        check++;
                    }
                }
                if (check == tags.Length)
                {
                    Console.WriteLine($"{topic.Key} | #" +
                        $"{string.Join(", #", topic.Value)}");
                }
                check = 0;
            }
        }
    }
}
