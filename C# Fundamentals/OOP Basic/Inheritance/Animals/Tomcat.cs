using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Tomcat:Cat
{
    public Tomcat(string name, int age) : base(name, age, "Male")
    {

    }

    public override void ProduceSound()
    {
        Console.WriteLine("MEOW");
    }
}

