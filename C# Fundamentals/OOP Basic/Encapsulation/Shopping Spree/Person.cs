using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Person
{
    private string name;

    public string Name
    {
        get { return name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Name cannot be empty");

            name = value;
        }
    }

    private decimal money;

    public decimal Money
    {
        get { return money; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Money cannot be negative");

            money = value;
        }
    }

    private List<Product> products;

    public List<Product> Products
    {
        get { return products; }
        private set { products = value; }
    }

    public Person(string name, decimal money)
    {
        Name = name;
        Money = money;
        Products = new List<Product>();
    }
}

