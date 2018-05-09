using System;
using System.Collections.Generic;
using System.Text;

public class Person : IComparable<Person>
{
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
    public string Name { get; set; }

    public int Age { get; set; }

    public override bool Equals(object obj)
    {
        if (obj is Person)
        {
            var p = (Person) obj;
            return p.Name == this.Name && p.Age == this.Age;
        }

        return false;
    }

    public int CompareTo(Person other)
    {
        var result = other.Name.CompareTo(this.Name);

        return result == 0
            ? this.Age.CompareTo(other.Age)
            : result;
    }

    public override int GetHashCode()
    {
        return this.Name.GetHashCode()+this.Age.GetHashCode();
    }
}

