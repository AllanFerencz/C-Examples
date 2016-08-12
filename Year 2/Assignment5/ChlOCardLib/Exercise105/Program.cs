//Name:              Allan Ferencz
//Date:              February 13, 2015
//Program Name:      Exercise105
//Description:       shows how to use the card class in a way to find out if you have a flush or not.


using Ch1OCardLib;
using System;


namespace Exercise105
{
    class Class1
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //created a new deck class object
                Deck playDeck = new Deck();
                //call the suffle meathod
                playDeck.Shuffle();
                //sets a switch for if the cards are flush
                bool isFlush = false;
                //sets the index of the hand to 0 to start from the first card
                int flushHandIndex = 0;
                //
                for (int hand = 0; hand < 10; hand++)
                {
                    //sets if its flush to true
                    isFlush = true;
                    //gets the suit of flush from the last card you drew
                    Suit flushSuit = playDeck.GetCard(hand * 5).suit;
                    //goes through the cards in your hand
                    for (int card = 1; card < 5; card++)
                    {
                        //checks if card is equal to the flush suit 
                        if (playDeck.GetCard(hand * 5 + card).suit != flushSuit)
                        {
                            // if even one is not equal to it then its set to false
                            isFlush = false;
                        }
                    }
                    //checks if its flush
                    if (isFlush)
                    {
                        //finds the hand index
                        flushHandIndex = hand * 5;
                        //breaks the loop since we found the flush
                        break;
                    }
                }
                //after the whole decks been drawen or if we break the loop, will check for a flush

                
                
                if (!isFlush)
                {
                    //writes to console that we drew a flush
                    Console.WriteLine("Flush!");
                    //for loop to show the card in hand
                    for (int card = 0; card < 5; card++)
                    {
                        //writes the card drawen
                        Console.WriteLine(playDeck.GetCard(flushHandIndex + card));
                    }   
                }
                else
                {
                    // write to console no flush was found
                    Console.WriteLine("No flush.");
                }
                //waits for user to enter in a key
                Console.ReadLine();
            }
        }
    }
}
