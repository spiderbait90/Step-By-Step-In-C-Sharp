using System;
using System.Collections.Generic;
using System.Text;

public class NameComparator : IComparer<Person>
{
    public int Compare(Person x, Person y)
    {
        var result = x.Name.Length.CompareTo(y.Name.Length);

        if (result == 0)
        {
            var firstP = char.ToLower(x.Name[0]);
            var secondP = char.ToLower(y.Name[0]);
            result = firstP.CompareTo(secondP);
        }

        return result;
    }
}

