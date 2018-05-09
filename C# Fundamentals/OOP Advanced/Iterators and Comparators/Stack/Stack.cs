using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Stack<T>:IEnumerable<T>
{
    private List<T> list;

    public Stack()
    {
        list = new List<T>();
    }

    public void Push(T[] digits)
    {
        list.AddRange(digits);
    }

    public void Pop()
    {
        if (!list.Any())
            throw new NullReferenceException("No elements");

        list.RemoveAt(list.Count-1);
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

