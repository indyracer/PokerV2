using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokerV2
{
    public partial class Form1 : Form
    {

        Card [] hand = new Card[5];
       

        public Form1()
        {
            InitializeComponent();
        }

        public void ShuffleButton_Click(object sender, EventArgs e)
        {
            Deck deck = new Deck();
            deck.Shuffle();

            Card dealt1 = deck.DealCard();
            Card dealt2 = deck.DealCard();
            Card dealt3 = deck.DealCard();
            Card dealt4 = deck.DealCard();
            Card dealt5 = deck.DealCard();

            hand[0] = dealt1;
            hand[1] = dealt2;
            hand[2] = dealt3;
            hand[3] = dealt4;
            hand[4] = dealt5;

            card1.Text = hand[0].DisplayCard();
            card2.Text = hand[1].DisplayCard();
            card3.Text = hand[2].DisplayCard();
            card4.Text = hand[3].DisplayCard();
            card5.Text = hand[4].DisplayCard();
            


        }

        
    }
}
