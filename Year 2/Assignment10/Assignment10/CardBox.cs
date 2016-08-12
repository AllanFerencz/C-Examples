//Name:              Allan Ferencz
//Date:              March 30, 2015
//Program Name:      CardBox.cs
//Description:       CardBox class is a custom user control. It is used for my cards being displayed onto a form.
//                   The CardBox is an example of how we can display cards for our final project.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Assignment10
{
    public partial class CardBox : UserControl
    {
        
        // event handler for when the card is flipped
        public event EventHandler cardFlipped;
    
        //called when the card is flipped
        public void onCardFlipped()
        {

            //swaps the face up value 
            if (isFaceUp == true)
            {
                isFaceUp = false;
            }
            else
            {
                isFaceUp = true;
            }
            //adds to the flip counter
            flipCount++;
        }
        
        //event hanhler for when the card is clicked
        public new event EventHandler Click;

        //returns a string and happens when card is clicked
        public string onCardClick()
        {
            //return the tostring and the information clicked with the event
            return ToString() + " was clicked last";
        }


        //holds if the card is face up or not
        private Boolean isFaceUp;
        //holds the rank value
        public int rank;
        //holds the suit value
        public int suit;
        //holds the flip count
        public int flipCount;
       
        //cardBox default constructor
        public CardBox()
        {
            InitializeComponent();
            isFaceUp = true;
            
            rank = 1;
            suit = 0;

        }

        //method for changing the isFaceUp property on the card
        public Boolean myFaceUp
        {
            get
            {
                return isFaceUp;
            }
            set
            {   
                isFaceUp = value;

                //checks if the event is null
                if (cardFlipped != null)
                {
                    cardFlipped(this, new EventArgs());
                }
                
            }
        }

        //setter for Rank
        public int myRank
        {
            get
            {
                return rank;
            }
            set
            {
                rank = value;
            }
        }
        //setter for Suit
        public int mySuit
        {
            get
            {
                return suit;
            }
            set
            {
                suit = value;
            }
        }
        //setter for flipCount
        public int myFlipCount
        {
            get
            {
                return flipCount;
            }
            set
            {
                flipCount = value;
            }

        }

        //set the default card image
        public void picCard_Load(Object sender, EventArgs e)
        {
            picCard.Image = Properties.Resources.cardClubs1;
        }

        //updates the card image
        public void picCard_UpdateImage(Object sender, EventArgs e)
        {
            //checks if the card is face up or not
            if (isFaceUp == true)
            {
                //swaps the image with a new one
                picCard.Image = (Image)Properties.Resources.ResourceManager.GetObject("card" + (Suit)Enum.ToObject(typeof(Suit), suit) + rank);
            }
            else
            {
                //if its face down swaps to the card back
                picCard.Image = Properties.Resources.cardBack_blue1;
            }     
        }

        //returns the card in string form
        public override string ToString()
        {
            if (!isFaceUp)
            {
                //return facedown if it was facedown;
                return "Face Down";
            } else
            {
                //returns the name of the enumerations by giving the rank of them
            return (Rank)Enum.ToObject(typeof(Rank),rank) + " of " + (Suit)Enum.ToObject(typeof(Suit), suit);
            }
        }

        //when card is clicked
        private void picCard_Click(object sender, EventArgs e)
        {
            //chekc if null
            if (Click != null)
            {
                //call the Click event
                Click(this, null);
            }
        }

    }
}
