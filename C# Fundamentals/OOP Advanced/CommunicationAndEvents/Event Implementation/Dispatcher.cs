using System;
using System.Collections.Generic;
using System.Text;

public class Dispatcher
{
    public event NameChangeEventHandler NameChange;
    private string name;
    public string Name
    {
        get
        {
            return name;
        }
         set
        {
            name = value;
            OnNameChange(new NameChangeEventArgs(value));
        }
    }

    public void OnNameChange(NameChangeEventArgs args)
    {
        NameChange?.Invoke(this, args);
    }
}

public delegate void NameChangeEventHandler(object sender, NameChangeEventArgs args);

