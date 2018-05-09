using System;

public class Citizen : IBuyer,ICitizen
{
    public Citizen(string name, string age, string id, string birthdate)
    {
        Name = name;
        Age = age;
        Id = id;
        Birthdate = birthdate;
    }

    public string Name { get; set; }
    public string Age { get; set; }
    public int Food { get; set; }
    public string Id { get; set; }
    public string Birthdate { get; set; }

    public void BuyFood()
    {
        Food += 10;
    }
}