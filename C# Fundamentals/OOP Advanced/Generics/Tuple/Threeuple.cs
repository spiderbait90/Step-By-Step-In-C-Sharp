using System;
using System.Collections.Generic;
using System.Text;

public class Threeuple<T, U, X>
{
    public Threeuple(T item1, U item2, X item3)
    {
        Item1 = item1;
        Item2 = item2;
        Item3 = item3;
    }
    public T Item1 { get; set; }

    public U Item2 { get; set; }

    public X Item3 { get; set; }

    public override string ToString()
    {
        return $"{Item1} -> {Item2} -> {Item3}";
    }
}
