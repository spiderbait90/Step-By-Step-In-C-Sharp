using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine()
            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        var n = int.Parse(Console.ReadLine());

        var addColection = new AddCollection<string>();
        var addRemoveCollection = new AddRemoveCollection<string>();
        var myList = new MyList<string>();

        var addColectionIndexes = string.Empty;
        var addRemoveColectionIndexes = string.Empty;
        var myListIndexes = string.Empty;

        var addColectionRemoved = string.Empty;
        var myListRemoved = string.Empty;

        for (int i = 0; i < input.Length; i++)
        {
            addColectionIndexes += addColection.Add(input[i]) + " ";
            addRemoveColectionIndexes += addRemoveCollection.Add(input[i]) + " ";
            myListIndexes += myList.Add(input[i]) + " ";
        }

        for (int i = 0; i < n; i++)
        {
            addColectionRemoved += addRemoveCollection.Remove() + " ";
            myListRemoved += myList.Remove() + " ";
        }

        Console.WriteLine(addColectionIndexes);
        Console.WriteLine(addRemoveColectionIndexes);
        Console.WriteLine(myListIndexes);
        Console.WriteLine(addColectionRemoved);
        Console.WriteLine(myListRemoved);
    }


}

