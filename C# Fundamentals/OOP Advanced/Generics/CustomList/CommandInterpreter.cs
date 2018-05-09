using System;

public class CommandInterpreter
{
    public void Read()
    {
        var list = new CustomList<string>();

        while (true)
        {
            var input = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (input[0] == "END")
                break;

            if (input[0] == "Add")
                list.Add(input[1]);

            else if (input[0] == "Remove")
                list.Remove(int.Parse(input[1]));

            else if (input[0] == "Contains")
                Console.WriteLine(list.Contains(input[1]));

            else if (input[0] == "Swap")
                list.Swap(int.Parse(input[1]), int.Parse(input[2]));

            else if (input[0] == "Greater")
                Console.WriteLine(list.CountGreaterThan(input[1]));

            else if (input[0] == "Max")
                Console.WriteLine(list.Max());

            else if (input[0] == "Min")
                Console.WriteLine(list.Min());

            else if (input[0] == "Sort")
                list.Sort();

            else if (input[0] == "Print")
                Console.WriteLine(string.Join(Environment.NewLine, list));
        }
    }
}