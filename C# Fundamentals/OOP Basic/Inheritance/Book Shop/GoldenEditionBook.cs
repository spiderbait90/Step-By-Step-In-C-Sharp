using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class GoldenEditionBook : Book
{
    public GoldenEditionBook(string title, string author, decimal price) : base(title, author, price)
    {

    }

    public override decimal Price
    {
        get
        {
            return base.Price;
        }
        set
        {
            base.Price = value + (value * 0.30m);
        }
    }

    public override string ToString()
    {
        return $"Type: {nameof(GoldenEditionBook)}{Environment.NewLine}" +
                      $"Title: {Title}{Environment.NewLine}" +
                      $"Author: {Author}{Environment.NewLine}" +
                      $"Price: {Price:f2}";
    }
}

