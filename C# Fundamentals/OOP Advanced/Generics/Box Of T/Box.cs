using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public static class Box<T>
where T : IComparable<T>
{
    public static int Compare(IEnumerable<T> collection,T element)
    {
        var count = 0;
        foreach (var e in collection)
        {
            if (e.CompareTo(element) > 0)
                count++;
        }

        return count;
    }
}

