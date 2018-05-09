using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Book
{
    private string title;

    public string Title
    {
        get { return title; }
        set
        {
            if (value.Length < 3)
            {
                throw new ArgumentException("Title not valid!");
            }
            title = value;
        }
    }

    private string author;

    public string Author
    {
        get { return author; }
        set
        {
            if (value.Any(char.IsDigit))
            {
                throw new ArgumentException("Author not valid!");
            }
            author = value;
        }
    }

    private decimal price;

    public virtual decimal Price
    {
        get { return price; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Price not valid!");
            }
            price = value;
        }
    }

    public Book(string author, string title,  decimal price)
    {
        Title = title;
        Author = author;
        Price = price;
    }

    public override string ToString()
    {
        return $"Type: {nameof(Book)}{Environment.NewLine}" +
               $"Title: {Title}{Environment.NewLine}" +
               $"Author: {Author}{Environment.NewLine}" +
               $"Price: {Price:f2}";
    }
}

