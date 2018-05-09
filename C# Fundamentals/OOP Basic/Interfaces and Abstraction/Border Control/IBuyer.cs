using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public interface IBuyer
{
    string Name { get; set; }

    string Age { get; set; }

    int Food { get; set; }

    void BuyFood();
}

