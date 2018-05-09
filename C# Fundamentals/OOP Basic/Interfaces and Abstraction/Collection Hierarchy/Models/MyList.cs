using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class MyList<T>:IMyList<T>
{
    private List<T> list;

    public MyList()
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
        var r = list[0];
        list.RemoveAt(0);
        return r;
    }

    public int Used()
    {
        return list.Count;
    }
}

