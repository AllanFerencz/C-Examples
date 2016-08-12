namespace Assignment10
{
    partial class frmAssignment10
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnFlip = new System.Windows.Forms.Button();
            this.cbbSuit = new System.Windows.Forms.ComboBox();
            this.cbbRank = new System.Windows.Forms.ComboBox();
            this.lblLastEvent = new System.Windows.Forms.Label();
            this.lblFlipCounter = new System.Windows.Forms.Label();
            this.cardBox = new Assignment10.CardBox();
            this.SuspendLayout();
            // 
            // btnFlip
            // 
            this.btnFlip.Location = new System.Drawing.Point(405, 88);
            this.btnFlip.Name = "btnFlip";
            this.btnFlip.Size = new System.Drawing.Size(75, 23);
            this.btnFlip.TabIndex = 0;
            this.btnFlip.Text = "Flip Card";
            this.btnFlip.UseVisualStyleBackColor = true;
            this.btnFlip.Click += new System.EventHandler(this.btnFlip_Click);
            // 
            // cbbSuit
            // 
            this.cbbSuit.FormattingEnabled = true;
            this.cbbSuit.Location = new System.Drawing.Point(405, 142);
            this.cbbSuit.Name = "cbbSuit";
            this.cbbSuit.Size = new System.Drawing.Size(121, 24);
            this.cbbSuit.TabIndex = 1;
            this.cbbSuit.SelectedIndexChanged += new System.EventHandler(this.cbbSuit_SelectedIndexChanged);
            // 
            // cbbRank
            // 
            this.cbbRank.FormattingEnabled = true;
            this.cbbRank.Location = new System.Drawing.Point(405, 193);
            this.cbbRank.Name = "cbbRank";
            this.cbbRank.Size = new System.Drawing.Size(121, 24);
            this.cbbRank.TabIndex = 2;
            this.cbbRank.SelectedIndexChanged += new System.EventHandler(this.cbbRank_SelectedIndexChanged);
            // 
            // lblLastEvent
            // 
            this.lblLastEvent.AutoSize = true;
            this.lblLastEvent.Location = new System.Drawing.Point(66, 303);
            this.lblLastEvent.Name = "lblLastEvent";
            this.lblLastEvent.Size = new System.Drawing.Size(0, 17);
            this.lblLastEvent.TabIndex = 4;
            // 
            // lblFlipCounter
            // 
            this.lblFlipCounter.AutoSize = true;
            this.lblFlipCounter.Location = new System.Drawing.Point(66, 353);
            this.lblFlipCounter.Name = "lblFlipCounter";
            this.lblFlipCounter.Size = new System.Drawing.Size(80, 17);
            this.lblFlipCounter.TabIndex = 5;
            this.lblFlipCounter.Text = "Card Flip: 0";
            // 
            // cardBox
            // 
            this.cardBox.Location = new System.Drawing.Point(66, 37);
            this.cardBox.myFaceUp = true;
            this.cardBox.myFlipCount = 0;
            this.cardBox.myRank = 1;
            this.cardBox.mySuit = 0;
            this.cardBox.Name = "cardBox";
            this.cardBox.Size = new System.Drawing.Size(176, 230);
            this.cardBox.TabIndex = 3;
            this.cardBox.Click += new System.EventHandler(this.cardBoc1_Click);
            // 
            // frmAssignment10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(564, 429);
            this.Controls.Add(this.lblFlipCounter);
            this.Controls.Add(this.lblLastEvent);
            this.Controls.Add(this.cardBox);
            this.Controls.Add(this.cbbRank);
            this.Controls.Add(this.cbbSuit);
            this.Controls.Add(this.btnFlip);
            this.Name = "frmAssignment10";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmAssignment10_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFlip;
        private System.Windows.Forms.ComboBox cbbSuit;
        private System.Windows.Forms.ComboBox cbbRank;
        private CardBox cardBox;
        private System.Windows.Forms.Label lblLastEvent;
        private System.Windows.Forms.Label lblFlipCounter;
    }
}

