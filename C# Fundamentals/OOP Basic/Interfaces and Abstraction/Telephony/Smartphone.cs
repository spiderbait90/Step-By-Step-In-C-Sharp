using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Smartphone : ICallable, IBrowseble
{
    public string Call(string num)
    {
        return num.Any(char.IsDigit) ?
            $"Calling... {num}" : "Invalid number!";
    }

    public string Browse(string site)
    {
        return site.Any(char.IsDigit) ?
            "Invalid URL!" : $"Browsing: {site}!";
    }
}

