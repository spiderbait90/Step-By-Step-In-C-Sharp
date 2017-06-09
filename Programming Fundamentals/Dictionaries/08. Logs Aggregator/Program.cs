using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Logs_Aggregator
{
    public class User
    {
        public string Name { get; set; }
        public int Duration { get; set; }
        public HashSet<string> Ips { get; set; }
    }
    public class Program
    {
       public static void Main(string[] args)
        {
            var data = new Dictionary<string, User>();
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                var ip = input[0];
                var name = input[1];
                var duration = int.Parse(input[2]);

                if (!data.ContainsKey(name))
                {
                    data[name] = new User();
                    data[name].Ips = new HashSet<string>();
                }

                data[name].Duration += duration;
                data[name].Ips.Add(ip);
                data[name].Name = name;
            }

            foreach (var item in data.Values.OrderBy(x=>x.Name))
            {
                Console.WriteLine($"{item.Name}: {item.Duration} " +
                    $"[{string.Join(", ",item.Ips.OrderBy(x=>x))}]");
            }
        }
    }
}
