//Name:              Allan Ferencz
//Date:              February 13, 2015
//Program Name:      deck.cs
//Description:       This enumeration picks sets the standard for suits

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch1OCardLib
{
    public class Deck
    {
        private Card[] cards;
    
        public Deck()
        {
            //sets the max number of cards to 52
            cards = new Card[52];
            //goes throw the suits
            for (int suitVal = 0; suitVal < 4; suitVal++)
            {
                //goes throw the ranks
                for (int rankVal = 1; rankVal < 14; rankVal++)
                {
                    //sets the card depending on what quit and rank it is currently on
                    cards[suitVal * 13 + rankVal - 1] = new Card((Suit)suitVal,
                                                                (Rank)rankVal);
                }
            }
        }
        //get card meathod
        public Card GetCard(int cardNum)
        {
            // if card is between the minimum and maximum card size will return the card
            if (cardNum >= 0 && cardNum <= 51)
                return cards[cardNum];
            else
                //else will throw an exception
                throw (new System.ArgumentOutOfRangeException("cardNum", cardNum,
                          "Value must be between 0 and 51."));
        }
        // shuffle meathod
        public void Shuffle()
        {
            //sets a new deck object
           Card[] newDeck = new Card[52];
            // sets a bool for is its each assigned card
           bool[] assigned = new bool[52];
            //a random number for to look for a card
           Random sourceGen = new Random();
            //search through all the cards in the deck
           for (int i = 0; i < 52; i++)
           {
               //index for card
              int destCard = 0;
               // resets the card found to false
              bool foundCard = false;
               //shift through the cards till it finds the random
              while (foundCard == false)
              {
                  //picks a random number to look for cards
                 destCard = sourceGen.Next(52);
                  //if the card exists break the while loop
                 if (assigned[destCard] == false)
                    foundCard = true;
              }
              //smark the spot as assigned
              assigned[destCard] = true;
               // sets the card the next card to a spot not assigned to
              newDeck[destCard] = cards[i];
            }
            //copys cards to newDeck
            newDeck.CopyTo(cards, 0);}
        }
}
