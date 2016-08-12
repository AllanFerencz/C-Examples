//Name:              Allan Ferencz
//Date:              February 20, 2015
//Program Name:      Coffee.cs
//Description:       Coffee class derives from Beverage. 
//                   Has a beantype that is a string to hold the name of the bea used to make the coffee.
//                   This class has an accessor to display the information inside of the class.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment6OOP
{
    //Coffee class inherits from Beverage
    sealed class Coffee : Beverage
    {
        //set beanType to hold the name of the type of bean used for the coffee
        public string beanType;

        //parameterised constructor for the coffee class
        //@param    sentBeanType name of the bean that was sent to it 
        public Coffee(string sentBeanType)
        {
            //sets the beanType to the parameter
            beanType = sentBeanType;
            //sets the tempature of this object to HOT
            this.temperature = Temperature.Hot;
        }
        //default constructor 
        public Coffee()
        {
            //default bean type is Arabica
            beanType = "Arabica";
            //default tempature is HOT
            this.temperature = Temperature.Hot;
        }

        //Accessor to display the information in the object
        public void showCoffee()
        {
            //display the variables avaliable to Coffee
            Console.WriteLine("Bean Type: " + beanType);
            Console.WriteLine("Served:    " + ServeTemp);
            Console.WriteLine("Price:     " + priceOfItem);
        }

    }
}
