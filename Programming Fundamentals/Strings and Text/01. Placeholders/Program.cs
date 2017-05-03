using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Placeholders
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var count = 0;

            while (input!="end")
            {
               var split = input.Split(new[] { '-', '>' }
            , StringSplitOptions.RemoveEmptyEntries);
                
                var sentance = split[0].Trim();
                
                var words = split[1].Split(new[] { ',', ' ' }
                , StringSplitOptions.RemoveEmptyEntries);

                foreach (var word in words)
                {
                    sentance = sentance.Replace($"{{{count}}}", word);
                    count++;
                }
                count = 0;
                Console.WriteLine(sentance);
                input = Console.ReadLine();
            }
        }
    }
}
