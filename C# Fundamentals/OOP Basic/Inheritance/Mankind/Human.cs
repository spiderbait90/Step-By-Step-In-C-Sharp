﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Human
{
    public Human(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    private string firstName;

    public string FirstName
    {
        get { return firstName; }
        set
        {
            if (char.IsLower(value.First()))
            {
                throw new ArgumentException("Expected upper case letter! Argument: firstName");
            }
            if (value.Length < 4)
            {
                throw new ArgumentException("Expected length at least 4 symbols! Argument: firstName");
            }
            firstName = value;
        }
    }

    private string lastName;

    public string LastName
    {
        get { return lastName; }
        set
        {
            if (char.IsLower(value[0]))
            {
                throw new ArgumentException("Expected upper case letter! Argument: lastName ");
            }
            if (value.Length < 3)
            {
                throw new ArgumentException("Expected length at least 3 symbols! Argument: lastName");
            }
            
            lastName = value;
        }
    }


}

