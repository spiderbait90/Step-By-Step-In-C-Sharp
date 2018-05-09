using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Count_Uppercase_Words
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new []{' '},StringSplitOptions.RemoveEmptyEntries)
                .Where(x => char.IsUpper(x.First())).ToArray();

            Console.WriteLine(string.Join(Environment.NewLine,input));
        }
    }
}
