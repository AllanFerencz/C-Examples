//Name:              Allan Ferencz
//Date:              February 20, 2015
//Program Name:      Program.cs
//Description:       Example to how the coffee class will run

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6OOP
{
    class Program
    {
        static void Main()
    {
        //instantiate objects of Coffee class 
        Coffee cuppaJoe = new Coffee();             //default constructor used
        Coffee cuppaFancy = new Coffee("Robusta");  //parameterised constructor used
        
        try //try block to attempt to make changes to the objects
        {
            cuppaJoe.Price = 1.5;       //set price to 1.5
            cuppaFancy.Price = -4.5;    //set price to -4.5 
        }
        catch(Exception ex) //catch all exceptions
        {
            Console.WriteLine(ex.Message); //display the exception caught to the user
            Console.ReadKey(); //wait for user input
            Console.WriteLine(""); //formating the console
        }
        
        //display the information inside of the coffee objects made above
        cuppaFancy.showCoffee();
        cuppaJoe.showCoffee();
        //wait for user input
        Console.ReadKey(); 
    }

    }
}
