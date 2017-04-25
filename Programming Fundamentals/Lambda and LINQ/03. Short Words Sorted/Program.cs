using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Short_Words_Sorted
{
    class Program
    {
        static void Main(string[] args)
        {            
            var words = Console.ReadLine().ToLower()
                .Split(new[]
                { ' ', '?', '!', '/', '\\', '"', '[', ']', ')', '(', ';',':',',','.','\'' }
                , StringSplitOptions.RemoveEmptyEntries).ToList();

            words = words
                .Where(x => x.Length < 5)
                .OrderBy(x => x)
                .Distinct()
                .ToList();
            Console.WriteLine(string.Join(", ", words));                
        }
    }
}
