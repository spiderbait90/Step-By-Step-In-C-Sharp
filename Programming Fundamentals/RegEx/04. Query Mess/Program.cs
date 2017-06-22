using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Query_Mess
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var regex = new Regex(@"([^?=&]+)=([^&]+)");
            var replace = new Regex(@"(%20|\+)+");
            
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "END")
                    break;

                var dic = new Dictionary<string, List<string>>();
                var matches = regex.Matches(input);


                foreach (Match match in matches)
                {
                    var key = match.Groups[1].Value;
                    var value = match.Groups[2].Value;
                    key = replace.Replace(key, " ").Trim();
                    value = replace.Replace(value, " ").Trim();                                    

                    if (!dic.ContainsKey(key))
                        dic[key] = new List<string>();
                    dic[key].Add(value);
                }               

                foreach (var item in dic)
                {
                    Console.Write(item.Key+"=["+string.Join(", ",item.Value)+"]");
                }
                Console.WriteLine();
            }

        }           
    }
}
