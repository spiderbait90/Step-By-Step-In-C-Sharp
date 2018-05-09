using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Animal
{
    public Animal(string name, int age, string gender)
    {
        Name = name;
        Age = age;
        Gender = gender;
    }

    private string name;

    public string Name
    {
        get { return name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Invalid input!");
            }
            name = value;
        }
    }

    private int age;

    public int Age
    {
        get { return age; }
        set
        {
            if (string.IsNullOrWhiteSpace(value.ToString()) ||
                value < 0)
            {
                throw new ArgumentException("Invalid input!");
            }
            age = value;
        }
    }

    private string gender;

    public string Gender
    {
        get { return gender; }
        set
        {
            if (value.ToLower() != "male" && value.ToLower() != "female")
            {
                throw new ArgumentException("Invalid input!");
            }
            gender = value;
        }
    }

    public virtual void ProduceSound()
    {
        Console.WriteLine("No Sound");
    }

}

