using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Person
{
    private decimal salary;
    private string firstName;
    private string lastName;
    private int age;

    public decimal Salary
    {
        get => salary;
        set
        {
            if (value < 460)
                throw new ArgumentException("Salary cannot be less than 460 leva!");
            salary = value;
        }
    }

    public string FirstName
    {
        get => firstName;
        set
        {
            if (value.Length < 3)
                throw new ArgumentException("First name cannot contain fewer than 3 symbols!");

            firstName = value;
        }
    }

    public string LastName
    {
        get => lastName;
        set
        {
            if (value.Length < 3)
                throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");

            lastName = value;
        }
    }

    public int Age
    {
        get => age;
        set
        {
            if (value <= 0)
                throw new ArgumentException("Age cannot be zero or a negative integer!");

            age = value;
        }
    }

    public Person(string firstName, string lastName, int age, decimal salary)
    {
        Salary = salary;
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }

    public override string ToString()
    {
        return $"{FirstName} {LastName} receives {Salary:f2} leva.";
    }

    public void IncreaseSalary(decimal bonus)
    {
        if (Age >= 30)
        {
            Salary += Salary * (bonus / 100);
        }
        else
        {
            Salary += Salary * ((bonus / 100) / 2);
        }
    }
}

