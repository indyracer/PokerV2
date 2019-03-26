using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerV2
{
    class Hand
    {
        Card handCard1, handCard2, handCard3, handCard4, handCard5;
        Card[] hand = new Card[5];

        //constructor
        public Hand()
        {
            Deck gameDeck = new Deck();
            gameDeck.Shuffle();

            hand[0] = gameDeck.DealCard();
            hand[1] = gameDeck.DealCard();
            hand[2] = gameDeck.DealCard();
            hand[3] = gameDeck.DealCard();
            hand[4] = gameDeck.DealCard();

            //fill the hand
            /*
            handCard1 = gameDeck.DealCard();
            handCard2 = gameDeck.DealCard();
            handCard3 = gameDeck.DealCard();
            handCard4 = gameDeck.DealCard();
            handCard5 = gameDeck.DealCard();

            //place cards in an array for evaluations
            hand[0] = handCard1;
            hand[1] = handCard2;
            hand[2] = handCard3;
            hand[3] = handCard4;
            hand[4] = handCard5; */
        }
    }
}
