using System.Collections;
using System.Collections.Generic;

public class CustomLinkedList<T>:IEnumerable<T>
{
    private List<T> list;
    public CustomLinkedList()
    {
        list = new List<T>();
    }

    public void Add(T element)
    {
        list.Add(element);
    }
    public bool Remove(T element)
    {
       return list.Remove(element);
    }

    public int Count()
    {
        return list.Count;
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