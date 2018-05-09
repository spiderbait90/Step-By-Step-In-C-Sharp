using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class ListyIterator<T> : IEnumerable<T>
{
    private List<T> list;
    private int index;
    public ListyIterator()
    {
        index = 0;
    }

    public void Create(params T[] args)
    {
        list = new List<T>(args);
    }

    public bool Move()
    {
        if (index + 1 > list.Count - 1)
            return false;

        index++;

        return true;
    }

    public void Print()
    {
        if (!list.Any())
            throw new Exception("Invalid Operation!");

        Console.WriteLine(list[index]);
    }

    public bool HasNext()
    {
        if (index + 1 > list.Count - 1)
        {
            return false;
        }
        return true;
    }

    public void PrintAll()
    {
        Console.WriteLine(string.Join(" ", list));
    }

    public IEnumerator<T> GetEnumerator()
    {
        return list.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}