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

        //constructor
        public Deck()
        {
            string [] faces = { "Deuce", "Three", "Four", "Five", "Six", "Seven", "Eight",
                "Nine", "Ten", "Jack", "Queen", "King", "Ace" };
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
