//Name:              Allan Ferencz
//Date:              February 20, 2015
//Program Name:      Beverage.cs
//Description:       Beverage class has 2 different variables and 2 procedures. Inherits from ISalesItem interface
//                   priceOfItem: holds the price of the object
//                   tempature: holds the tempature the item will be served at
//                   This class can change the tempature and the price of the item.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment6OOP
{

    //Beverage Class that inherits from ISalesItem interface
    //Interface supplies Price
    abstract class Beverage : ISalesItem 
    {
        //Price of beverage
        public double priceOfItem;
        //Tempature of the beverage
        public Temperature temperature;     

        //default constructor of a beverage
        public Beverage()
        {
            //sets the price of a beverage to 2
            Price = 2.00;
            //sets the tempature of the beverage to cold 
            temperature = Temperature.Cold;
        }

        //Price property that comes from interface
        public double Price
        {
            get
            {
                return priceOfItem; //returns the price of the item
            }
            set
            {
                //checks if the price is lower than 0
                if (value < 0.00)
                {
                    //throws an exception if the item is negative
                    throw new System.ArgumentException("Price cannot be negative");
                    //will break out the code if hits this point
                }
                //sets the price of the item to value
                priceOfItem = value;
            }
        }
        // sets the tempature of the beverage.
        public Temperature ServeTemp
        {
            get
            {
                return temperature; //return the temperature
            }
            set
            {
                temperature = value; //set the value of temperature to value
            }
        }


    }
}
