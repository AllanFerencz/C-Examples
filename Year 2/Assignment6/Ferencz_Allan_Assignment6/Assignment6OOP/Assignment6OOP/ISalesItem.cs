//Name:              Allan Ferencz
//Date:              February 20, 2015
//Program Name:      ISalesItem.cs
//Description:       interface for the Beverage class

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment6OOP
{
    public interface ISalesItem
    {
        double Price { get; set; } // sets a requirement that all classes derived from this interface have this procedure
    }
}
