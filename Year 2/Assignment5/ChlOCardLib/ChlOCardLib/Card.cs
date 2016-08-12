//Name:              Allan Ferencz
//Date:              February 13, 2015
//Program Name:      Card.cs
//Description:       shows how to use the card class in a way to find out if you have a flush or not.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch1OCardLib
{
    public class Card
    {
        //holds the rank of a card
        public readonly Rank rank;
        //holds the suit of a card
        public readonly Suit suit;

        //constructor to instantiate a new card
        public Card(Suit newSuit, Rank newRank)
        {
            //sets the suit past to it to the suit in the class
            suit = newSuit;
            //sets the rank past to it to the rnak in the class
            rank = newRank;
        }

        //default constructor
        private Card()
        {
        }

        //meathod for returning the rank and suit of the card
        public String ToString()
        {
            return "The " + rank + " of " + suit + "s";
        }
    }
}
