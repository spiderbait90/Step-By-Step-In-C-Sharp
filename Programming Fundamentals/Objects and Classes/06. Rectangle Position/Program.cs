using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Rectangle_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = ReadRectangle();
            Rectangle r2 = ReadRectangle();

            if (r1.IsInside(r2))
                Console.WriteLine("Inside");
            else
                Console.WriteLine("Not inside");

        }

        private static Rectangle ReadRectangle()
        {
            var input = Console.ReadLine().Split(' ')
                .Select(int.Parse).ToList();

            var rectangle = new Rectangle();
            rectangle.Left = input[0];
            rectangle.Top = input[1];
            rectangle.Width = input[2];
            rectangle.Height = input[3];
            return rectangle;
        }
        class Rectangle
        {
            public int Left { get; set; }
            public int Top { get; set; }
            public int Width { get; set; }
            public int Height { get; set; }
            public int Right
            {
                get
                {
                    return Left + Width;
                }
            }
            public int Bottom
            {
                get
                {
                    return Top + Height;
                }
            }
            public bool IsInside(Rectangle r)
            {
                return (r.Left <= Left) && (r.Right >= Right) &&
                   (r.Top <= Top) && (r.Bottom >= Bottom);
            }
        }
    }
}
