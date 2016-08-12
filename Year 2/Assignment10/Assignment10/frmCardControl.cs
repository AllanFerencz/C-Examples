//Date:              March 30, 2015
//Program Name:      frmCardControl.cs
//Description:       form to test my CardBox user control class. it changes values and the control changes.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment10
{
    public partial class frmAssignment10 : Form
    {
        //constructor
        public frmAssignment10()
        {
            InitializeComponent();
        }
        
        //when the form loads it sets everything up
        private void frmAssignment10_Load(object sender, EventArgs e)
        {
            //sets the combo boxes with the correct information
            cbbRank.DataSource = Enum.GetValues(typeof(Rank));
            cbbSuit.DataSource = Enum.GetValues(typeof(Suit));
            //sets the events to the handlers
            cardBox.cardFlipped += btnFlip_Click;
            cardBox.Click += cardBoc1_Click;
        }
        
        
        //when the button is clicked to flip the card
        private void btnFlip_Click(object sender, EventArgs e)
        {
           //call the method to flip the card
            cardBox.onCardFlipped();
            //update the image on the card
            cardBox.picCard_UpdateImage(this, new EventArgs());
            //update the counter
            lblFlipCounter.Text = "Card Flip: " + cardBox.myFlipCount;
        }

        private void cbbSuit_SelectedIndexChanged(object sender, EventArgs e)
        {
            //change the suit of the card to the select index of the comboBox
            cardBox.mySuit = (int)cbbSuit.SelectedValue;
            //update the card image
            cardBox.picCard_UpdateImage(this, new EventArgs());
        }

        private void cbbRank_SelectedIndexChanged(object sender, EventArgs e)
        {
            //change the rank of the card to the select index of the comboBox
            cardBox.myRank = (int)cbbRank.SelectedValue;
            //update the card image
            cardBox.picCard_UpdateImage(this, new EventArgs());
        }

        private void cardBoc1_Click(object sender, EventArgs e)
        {
            //changed the label of the last event for the card click
            lblLastEvent.Text = cardBox.onCardClick(); ;

        }




    }
}
