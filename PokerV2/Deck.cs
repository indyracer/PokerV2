using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerV2
{
    class Deck
    {
        protected Card [] deck;
        protected int currentCard = -1;

        //create dictionary of images
        //setup a method to get the image for a card, compare the card.face and card.suit values to the 
        //dictionary key values??

        //constructor
        public Deck()
        {
            string [] faces = { "2", "3", "4", "5", "6", "7", "8",
                "9", "10", "Jack", "Queen", "King", "Ace" };
            string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };

            deck = new Card[52];  

            //populate deck with cards
            for (int count = 0; count < deck.Length; count++)
            {
                deck[count] = new Card(faces[count % 13], suits[count / 13]);
            }
        }

        public void Shuffle()
        {
            //for each card pick another random card and swap them
            
            Random rand = new Random();
            for(int i = 0; i < deck.Length; i++)
            {
                
                int r = i + rand.Next(52 - i);
                Card temp = deck[r];
                deck[r] = deck[i];
                deck[i] = temp;
            }
        }

        public Card DealCard()
        {
           return deck[++currentCard];
            
        }


    }
}
