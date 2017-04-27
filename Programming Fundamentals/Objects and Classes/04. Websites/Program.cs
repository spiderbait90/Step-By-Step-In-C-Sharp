using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Websites
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var webSites = new List<Website>();
            while (input!="end")
            {
                var split = input.Split(new[] { ' ', '|',',' },
                    StringSplitOptions.RemoveEmptyEntries);

                var host = split[0];var domain = split[1];

                var site = new Website();
                site.Host = host; site.Domain = domain;

                if (split.Length>2)
                {
                    var queries = split.Skip(2).ToList();
                    site.Queries = queries;
                }
                webSites.Add(site);
                input = Console.ReadLine();
            }            
            foreach (var site in webSites)
            {
                if (site.Queries== null)
                    Console.WriteLine($"https://www.{site.Host}.{site.Domain}");
                else
                {
                    Console.WriteLine($"https://www.{site.Host}.{site.Domain}/query?=[" +
                        string.Join("]&[", site.Queries) + "]");
                                 
                }
            }
        }
    }
    public class Website
    {
        public string Host { get; set; }
        public string Domain { get; set; }
        public List<string> Queries { get; set; }
    }
}
