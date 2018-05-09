using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Pizza
{
    public Pizza(string name, Dough dough)
    {
        Name = name;
        Dough = dough;
        Toppings = new List<Topping>();
    }

    private string name;

    public string Name
    {
        get { return name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value) || value?.Length > 15)
                throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");

            name = value;
        }
    }

    private Dough dough;

    public Dough Dough
    {
        get { return dough; }
        set { dough = value; }
    }

    private List<Topping> toppings;

    public List<Topping> Toppings
    {
        get { return toppings; }
        private set { toppings = value; }
    }

    public double CalculateTotalCalories()
    {
        return Dough.CalculateCalories() + toppings.Sum(x => x.CalculateCalories());
    }

}

