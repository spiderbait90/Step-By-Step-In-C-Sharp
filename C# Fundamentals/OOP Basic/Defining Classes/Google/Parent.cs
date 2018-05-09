using System;

public class Parent
{
    public Parent(string parentName, DateTime parentBirthday)
    {
        ParentName = parentName;
        ParentBirthday = parentBirthday;
    }

    public string ParentName { get; set; }

    public DateTime ParentBirthday { get; set; }
}