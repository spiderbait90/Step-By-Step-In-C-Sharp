using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class CustomList<T>:IEnumerable<T>
where T : IComparable<T>
{
    private List<T> list;

    public CustomList()
    {
        list = new List<T>();
    }

    public void Add(T element)
    {
        list.Add(element);
    }

    public T Remove(int index)
    {
        var el = list[index];
        list.RemoveAt(index);
        return el;
    }

    public bool Contains(T element)
    {
        return list.Any(e => e.CompareTo(element) == 0);
    }

    public void Swap(int index1, int index2)
    {
        var a = list[index1];
        var b = list[index2];
        list[index1] = b;
        list[index2] = a;
    }

    public int CountGreaterThan(T element)
    {
        return list.Count(x => x.CompareTo(element) > 0);
    }

    public T Max()
    {
        return list.Max();
    }

    public T Min()
    {
        return list.Min();
    }

    public IEnumerator<T> GetEnumerator()
    {
        return list.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return list.GetEnumerator();
    }

    public void Sort()
    {
        list = list.OrderBy(x => x).ToList();
    }
}

