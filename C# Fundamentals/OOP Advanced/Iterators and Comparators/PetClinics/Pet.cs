using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

public class Pet
{
    private string _name;
    private string _kind;
    public Pet(string name, int age, string kind)
    {
        Name = name;
        Age = age;
        Kind = kind;
    }

    public string Name
    {
        get => _name;
        private set
        {
            if (value.Length < 1 ||
                value.Length > 50 ||
                !Regex.IsMatch(value, @"^[a-zA-Z]+$"))
            {
                throw new ArgumentException("invalid name");
            }

            _name = value;
        } 
    }

    public int Age { get; }

    public string Kind
    {
        get => _kind;
        private set
        {
            if (value.Length < 1 ||
                value.Length > 50 ||
                !Regex.IsMatch(value, @"^[a-zA-Z]+$"))
            {
                throw new ArgumentException("invalid kind");
            }

            _kind = value;
        }
    }

    public override string ToString()
    {
        return $"{Name} {Age} {Kind}";
    }
}

