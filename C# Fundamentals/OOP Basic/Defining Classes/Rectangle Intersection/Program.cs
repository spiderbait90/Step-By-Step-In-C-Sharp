using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    public static void Main(string[] args)
    {
        var input = Console.ReadLine().Split(new []{' '},StringSplitOptions.RemoveEmptyEntries);

        var rectangles = new List<Rectangle>();

        var n = decimal.Parse(input[0]);
        var m = decimal.Parse(input[1]);

        for (int i = 0; i < n; i++)
        {
            var line = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var id = line[0];
            var width = decimal.Parse(line[1]);
            var height = decimal.Parse(line[2]);
            var x = decimal.Parse(line[3]);
            var y = decimal.Parse(line[4]);

            rectangles.Add(new Rectangle(id,width,height,x,y));
        }

        for (int i = 0; i < m; i++)
        {
            var line = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var id1 = line[0];
            var id2 = line[1];

            var rec1 = rectangles.Find(x => x.Id == id1);
            var rec2 = rectangles.Find(x => x.Id == id2);

            Console.WriteLine(rec1.IntersectsRectangle(rec2).ToString().ToLower());
        }
    }
}

