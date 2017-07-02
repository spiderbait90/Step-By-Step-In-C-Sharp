using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06.Email_Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var filter = new Regex(@"(^[a-zA-Z]{5,})@(([a-z]{3,})(\.com|\.bg|\.org)$)");
            var domains = new Dictionary<string, HashSet<string>>();

            for (int i = 0; i < n; i++)
            {
                var mail = Console.ReadLine();
                var match = filter.Match(mail);

                if (match.Success)
                {
                    var domain = match.Groups[2].Value;
                    var user = match.Groups[1].Value;

                    if (!domains.ContainsKey(domain))
                        domains[domain] = new HashSet<string>();
                    domains[domain].Add(user);
                }
            }
            foreach (var domain in domains
                .OrderByDescending(x=>x.Value.Count))
            {
                Console.WriteLine($"{domain.Key}:");
                foreach (var user in domain.Value)
                {
                    Console.WriteLine($"### {user}");
                }
            }
        }
    }
}
