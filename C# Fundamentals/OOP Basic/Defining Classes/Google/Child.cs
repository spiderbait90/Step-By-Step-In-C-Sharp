using System;

public class Child
{
    public Child(string childName, DateTime childBirthday)
    {
        ChildName = childName;
        ChildBirthday = childBirthday;
    }

    public string ChildName { get; set; }

    public DateTime ChildBirthday { get; set; }
}