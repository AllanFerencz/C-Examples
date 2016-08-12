    //Name:              Allan Ferencz
    //Date:              February 4, 2015
    //Program Name:      Ch09Ex02
    //Description:       Shows access levels and the deference in using the word external an internal

   using System;
   using System.Collections.Generic;
   using System.Linq;
   using System.Text;
   using System.Threading.Tasks;
   using Ch09ClassLib;
   
   namespace Ch09Ex02
   {
       class Program
       {
           static void Main(string[] args)
           {
               MyExternalClass myObj = new MyExternalClass(); //Makes a new external class and saves it into myObj
               Console.WriteLine(myObj.ToString()); // write the myObj while setting it to string
               Console.ReadKey(); // waits for user input
           
                //if I tried to access the internal class it would error by being out of scope
           }
   
       }
        
    }
