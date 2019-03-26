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

            card1.Text = dealt1.DisplayCard();
            card2.Text = dealt2.DisplayCard();
            card3.Text = dealt3.DisplayCard();
            card4.Text = dealt4.DisplayCard();
            card5.Text = dealt5.DisplayCard();
            


        }

        
    }
}
