using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class AddRemoveCollection<T>:IAddRemoveCollection<T>
{
    private List<T> list;

    public AddRemoveCollection()
    {
     list = new List<T>();   
    }
    public int Add(T element)
    {
        list.Insert(0,element);
        return 0;
    }

    public T Remove()
    {
        var r = list[list.Count - 1];
        list.RemoveAt(list.Count-1);
        return r;
    }
}

