using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class AddCollection<T> : IAddCollection<T>
{
    private List<T> list;

    public AddCollection()
    {
        list = new List<T>();
    }

    public int Add(T element)
    {
        list.Add(element);
        return list.Count - 1;
    }
}

