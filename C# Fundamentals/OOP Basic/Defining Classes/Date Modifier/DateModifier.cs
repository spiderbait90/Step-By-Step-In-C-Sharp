using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_Modifier
{
    public class DateModifier
    {
        public long DaysDiff(string date1, string date2)
        {
            var first = DateTime.Parse(date1);
            var second = DateTime.Parse(date2);
            var days = 0;
            if (first > second)
            {
                for (DateTime i = second; i < first; i = i.AddDays(1))
                {
                    days++;
                }
            }
            else
            {
                for (DateTime i = first; i < second; i = i.AddDays(1))
                {
                    days++;
                }
            }
            
            return days;
        }
    }
}
