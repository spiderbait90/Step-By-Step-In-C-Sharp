using System;
using System.Linq;
using System.Reflection;

public class Tracker
{
    public Tracker()
    {
    }

    public void PrintMethodsByAuthor()
    {
        var type = typeof(StartUp);
        var methos = type.GetMethods(BindingFlags.Instance |
                                     BindingFlags.Public |
                                     BindingFlags.Static);
        
        foreach (var m in methos)
        {
            if (m.CustomAttributes.Any(x => x.AttributeType == typeof(SoftUniAttribute)))
            {
                var attrs = m.GetCustomAttributes(false);

                foreach (SoftUniAttribute a in attrs)
                {
                    Console.WriteLine($"{m.Name} is written by {a.Name}");
                }
            }
        }
    }
}