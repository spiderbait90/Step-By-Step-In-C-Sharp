using System;


public class Program
{
    public static void Main(string[] args)
    {
        var strings = ArrayCreator.Create(5, "Pesho");
        var integers = ArrayCreator.Create(10, 33);

    }
}

public static class ArrayCreator
{
    public static T[] Create<T>(int lenght, T item)
    {
        var arr = new T[lenght];

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = item;
        }

        return arr;
    }
}