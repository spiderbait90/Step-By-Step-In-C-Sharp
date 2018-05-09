using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Family
{
    private List<Person> people = new List<Person>();

    public void AddMember(Person member)
    {
        people.Add(member);
    }

    public Person GetOldestMember()
    {
        return people.OrderByDescending(x => x.Age).First();
    }

    public List<Person> AllAbove30()
    {
        return people.Where(x => x.Age > 30).OrderBy(x => x.Name).ToList();
    }
}

