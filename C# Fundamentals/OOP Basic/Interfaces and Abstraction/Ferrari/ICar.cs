using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public interface ICar
{
    string Model { get; set; }

    string Driver { get; set; }

    string Breaks();

    string Gas();
}

