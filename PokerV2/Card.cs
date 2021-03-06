﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerV2
{
    class Card  
    {
        public String face;
        public String suit;
        
        //constructor to initialie card
        public Card(string cardFace, string cardSuit)
        {
            face = cardFace;
            suit = cardSuit;
        }

        //card methods
        public String GetCardFace()
        {
            return face;
        }

        public String GetCardSuit()
        {
            return suit;
        }

        public String DisplayCard()
        {
            return face + " of " + suit;
        }

        public String ImageName()
        {
            return face.ToLower() + "_of_" + suit.ToLower() + ".png";
        }
    }
}
