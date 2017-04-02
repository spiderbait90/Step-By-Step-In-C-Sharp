using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._1000_Days_After_Birth
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo asd = CultureInfo.InvariantCulture;
            string format = "dd-MM-yyyy";
            var date = DateTime.ParseExact(Console.ReadLine(), format, asd);
            var date2 = date.AddDays(999);
            Console.WriteLine(date2.ToString(format));


        }
    }
}
