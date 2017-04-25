using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace _01.Register_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var nameAndDate = new Dictionary<string, DateTime>();
            while (input!="end")
            {
                var splitInput = input.Split(new[] {'-','>',' '}
                ,StringSplitOptions.RemoveEmptyEntries);
                var name = splitInput[0];
                var date = DateTime.ParseExact(splitInput[1], "dd/MM/yyyy", CultureInfo.InvariantCulture);
                nameAndDate.Add(name, date);
                input = Console.ReadLine();
            }

            var result = nameAndDate
                .Reverse()
                .OrderBy(x => x.Value)
                .Take(5)
                .OrderByDescending(x=>x.Value)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var key in result)
            {
                Console.WriteLine(key.Key);
            }
                
        }
    }
}
