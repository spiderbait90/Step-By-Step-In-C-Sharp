using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_Modifier
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var firstDate = Console.ReadLine();
            var secondDate = Console.ReadLine();

            var dateModifier = new DateModifier();
            var days = dateModifier.DaysDiff(firstDate, secondDate);

            Console.WriteLine(days);
        }
    }
}
