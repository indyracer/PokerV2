using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PokerV2
{
    public partial class Form1 : Form
    {

        Card [] hand = new Card[5];
        //path to get images
        public const string path = @"C:\\Users\\bobco\\source\\repos\\PokerV2\\PokerV2\\Resources\\";
        //Array to hold pictures of cards
        Image[] cardImages;
       

        public Form1()
        {
            InitializeComponent();
            //initalize card images array and add the cards
            cardImages = new Image[52];
            cardImages[0] = Image.FromFile(path + "2_of_clubs.png");
            cardImages[1] = Image.FromFile(path + "3_of_clubs.png");
            cardImages[2] = Image.FromFile(path + "4_of_clubs.png");
            cardImages[3] = Image.FromFile(path + "5_of_clubs.png");
            cardImages[4] = Image.FromFile(path + "6_of_clubs.png");
            cardImages[5] = Image.FromFile(path + "7_of_clubs.png");
            cardImages[6] = Image.FromFile(path + "8_of_clubs.png");
            cardImages[7] = Image.FromFile(path + "9_of_clubs.png");
            cardImages[8] = Image.FromFile(path + "10_of_clubs.png");
            cardImages[9] = Image.FromFile(path + "jack_of_clubs.png");
            cardImages[10] = Image.FromFile(path + "queen_of_clubs.png");
            cardImages[11] = Image.FromFile(path + "king_of_clubs.png");
            cardImages[12] = Image.FromFile(path + "ace_of_clubs.png");
            cardImages[13] = Image.FromFile(path + "2_of_diamonds.png");
            cardImages[14] = Image.FromFile(path + "3_of_diamonds.png");
            cardImages[15] = Image.FromFile(path + "4_of_diamonds.png");
            cardImages[16] = Image.FromFile(path + "5_of_diamonds.png");
            cardImages[17] = Image.FromFile(path + "6_of_diamonds.png");
            cardImages[18] = Image.FromFile(path + "7_of_diamonds.png");
            cardImages[19] = Image.FromFile(path + "8_of_diamonds.png");
            cardImages[20] = Image.FromFile(path + "9_of_diamonds.png");
            cardImages[21] = Image.FromFile(path + "10_of_diamonds.png");
            cardImages[22] = Image.FromFile(path + "jack_of_diamonds.png");
            cardImages[23] = Image.FromFile(path + "queen_of_diamonds.png");
            cardImages[24] = Image.FromFile(path + "king_of_diamonds.png");
            cardImages[25] = Image.FromFile(path + "ace_of_diamonds.png");
            cardImages[26] = Image.FromFile(path + "2_of_hearts.png");
            cardImages[27] = Image.FromFile(path + "3_of_hearts.png");
            cardImages[28] = Image.FromFile(path + "4_of_hearts.png");
            cardImages[29] = Image.FromFile(path + "5_of_hearts.png");
            cardImages[30] = Image.FromFile(path + "6_of_hearts.png");
            cardImages[31] = Image.FromFile(path + "7_of_hearts.png");
            cardImages[32] = Image.FromFile(path + "8_of_hearts.png");
            cardImages[33] = Image.FromFile(path + "9_of_hearts.png");
            cardImages[34] = Image.FromFile(path + "10_of_hearts.png");
            cardImages[35] = Image.FromFile(path + "jack_of_hearts.png");
            cardImages[36] = Image.FromFile(path + "queen_of_hearts.png");
            cardImages[37] = Image.FromFile(path + "king_of_hearts.png");
            cardImages[38] = Image.FromFile(path + "ace_of_hearts.png");
            cardImages[26] = Image.FromFile(path + "2_of_spades.png");
            cardImages[27] = Image.FromFile(path + "3_of_spades.png");
            cardImages[28] = Image.FromFile(path + "4_of_spades.png");
            cardImages[29] = Image.FromFile(path + "5_of_spades.png");
            cardImages[30] = Image.FromFile(path + "6_of_spades.png");
            cardImages[31] = Image.FromFile(path + "7_of_spades.png");
            cardImages[32] = Image.FromFile(path + "8_of_spades.png");
            cardImages[33] = Image.FromFile(path + "9_of_spades.png");
            cardImages[34] = Image.FromFile(path + "10_of_spades.png");
            cardImages[35] = Image.FromFile(path + "jack_of_spades.png");
            cardImages[36] = Image.FromFile(path + "queen_of_spades.png");
            cardImages[37] = Image.FromFile(path + "king_of_spades.png");
            cardImages[38] = Image.FromFile(path + "ace_of_spades.png");

        }


        public void ShuffleButton_Click(object sender, EventArgs e)
        {
            //clear previous EvaluationLabel value
            evaluationLabel.Text = "";

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

            cardPic1.Image = DisplayImage(hand[0]);
            cardPic2.Image = DisplayImage(hand[1]);
            cardPic3.Image = DisplayImage(hand[2]);
            cardPic4.Image = DisplayImage(hand[3]);
            cardPic5.Image = DisplayImage(hand[4]);
            


        }

        public void evaluationButton_Click(object sender, EventArgs e)
        {
            //call methods to evaluate hand here
          
            if (IsPair(hand))
            {
                evaluationLabel.Text = "Pair";
            }
            else if (IsTwoPair(hand))
            {
                evaluationLabel.Text = "Two Pair";
            }
            else if (IsThreeOfKind(hand))
            {
                evaluationLabel.Text = "Three of a Kind";
            }
            else if (IsFourOfKind(hand))
            {
                evaluationLabel.Text = "Four of Kind";
            }
            else if (IsFullHouse(hand))
            {
                evaluationLabel.Text = "Full House";
            }
            else if(IsStraight(hand) && !IsFlush(hand))
            {
                evaluationLabel.Text = "Straight";
            }
            else if(IsStraight(hand) && IsFlush(hand) && !IsRoyalFlush(hand))
            {
                evaluationLabel.Text = "Straight Flush";
            }
            else if (IsRoyalFlush(hand))
            {
                evaluationLabel.Text = "Royal Flush";
            }
            else if (IsFlush(hand))
            {
                evaluationLabel.Text = "Flush";
            }
            else
            {
                evaluationLabel.Text = "High Card";
            }

        }

        //methods used to evaluate hands

        //calculate suit score, place in array
        internal static int [] SuitScore (Card [] hand)
        {
            int diamondScore = 0, spadeScore = 0, heartScore = 0, clubScore = 0;

            for(int i =0; i < hand.Length; i++)
            {
                switch (hand[i].GetCardSuit())
                {
                    case "Diamonds":
                        diamondScore++;
                        break;
                    case "Spades":
                        spadeScore++;
                        break;
                    case "Hearts":
                        heartScore++;
                        break;
                    default:
                        clubScore++;
                        break;                            
                }
            }
            int[] SuitScores = { diamondScore, spadeScore, heartScore, clubScore };
            return SuitScores;
        }

        //calculate face score, place in array
        internal static int [] FaceScore (Card [] hand)
        {
            int dueceScore = 0, threeScore = 0, fourScore = 0, fiveScore = 0, sixScore = 0,
                sevenScore = 0, eightScore = 0, nineScore = 0, tenScore = 0, jackScore = 0,
                queenScore = 0, kingScore = 0, aceScore = 0;
            //add loop to go through cards and use switch to calculate scores
            for (int i = 0; i < hand.Length; i++)
            {
                switch (hand[i].GetCardFace())
                {
                    case "2":
                        dueceScore++;
                        break;
                    case "3":
                        threeScore++;
                        break;
                    case "4":
                        fourScore++;
                        break;
                    case "5":
                        fiveScore++;
                        break;
                    case "6":
                        sixScore++;
                        break;
                    case "7":
                        sevenScore++;
                        break;
                    case "8":
                        eightScore++;
                        break;
                    case "9":
                        nineScore++;
                        break;
                    case "10":
                        tenScore++;
                        break;
                    case "Jack":
                        jackScore++;
                        break;
                    case "Queen":
                        queenScore++;
                        break;
                    case "King":
                        kingScore++;
                        break;
                    default:
                        aceScore++;
                        break;
                }
            }

            //place values into array
            int[] faceScores = {dueceScore, threeScore, fourScore, fiveScore, sixScore,
            sevenScore, eightScore, nineScore, tenScore, jackScore, queenScore, kingScore, aceScore};

            return faceScores;
        }

        //evaluate hand, check if pair
        internal static Boolean IsPair(Card [] hand)
        {
            Boolean isPair = false;
            int[] score = FaceScore(hand);
            //run through hand, check if only 1 faceScore == 2 and 3 other faceScores == 1
            int countTwo = 0, countOne = 0, countOther = 0;
            for(int i = 0; i < score.Length; i++)
            {
                if(score[i] == 2)
                {
                    countTwo++;
                }
                else if (score[i] == 1){
                    countOne++;
                }
                else
                {
                    countOther++;
                }
            }

            if(countTwo == 1 && countOne == 3)
            {
                isPair = true;
            }

            return isPair;
        }

        //evaluate hand, check if two pair
        internal static Boolean IsTwoPair(Card [] hand)
        {
            Boolean isTwoPair = false;
            int countTwo = 0, countOne = 0, countOther = 0;
            //place face scores in an array.  Looking for countTwo == 2, countOne == 1 
            int[] scores = FaceScore(hand);

            for(int i = 0; i < scores.Length; i++)
            {
                if(scores[i] == 2)
                {
                    countTwo++;
                }
                else if(scores[i] == 1)
                {
                    countOne++;
                }
                else
                {
                    countOther++;
                }
            }

            if(countTwo == 2 && countOne == 1)
            {
                isTwoPair = true;
            }

            return isTwoPair;
        }

        //evaluate three of a kind here.
        internal static Boolean IsThreeOfKind(Card[] hand)
        {
            //look at scores, looking for one face of 3, and 2 of 1
            Boolean isThreeKind = false;
            int[] scores = FaceScore(hand);
            int countThree = 0, countOne = 0, countOther = 0;

            for(int i = 0; i < scores.Length; i++)
            {
                if(scores[i] == 3)
                {
                    countThree++;
                }
                else if (scores[i] == 1)
                {
                    countOne++;
                }
                else
                {
                    countOther++;
                }
            }

            if(countThree == 1 && countOne == 2)
            {
                isThreeKind = true;
            }

            return isThreeKind;
        }

        //evaluate four of a kind
        internal static Boolean IsFourOfKind(Card[] hand)
        {
            //look at scores, should be 1 with count of 4, and 1 with count of 1
            Boolean isFourKind = false;
            int [] scores = FaceScore(hand);

            int countFour = 0, countOne = 0, countOther = 0;

            for(int i = 0; i < scores.Length; i++)
            {
                if(scores[i] == 4)
                {
                    countFour++;
                }
                else if (scores[i] == 1)
                {
                    countOne++;
                }
                else
                {
                    countOther++;
                }
            }

            if(countFour == 1 && countOne == 1)
            {
                isFourKind = true;
            }

            return isFourKind;
        }

        //evaluate if Full House START HERE
        internal static Boolean IsFullHouse(Card [] hand)
        {
            //look at scores...looking for 1 count == 3, 1 count == 2
            Boolean isFullHouse = false;
            int[] scores = FaceScore(hand);
            int countTwo = 0, countThree = 0, countOther = 0;

            for(int i = 0; i < scores.Length; i++)
            {
                if (scores[i] == 2)
                {
                    countTwo++;
                }
                else if(scores[i] == 3)
                {
                    countThree++;
                }
                else
                {
                    countOther++;
                }
            }

            if(countTwo == 1 && countThree == 1)
            {
                isFullHouse = true;
            }

            return isFullHouse;
        }

        //evaluate if flush
        internal static Boolean IsFlush(Card [] hand)
        {
            Boolean isFlush = false;
            int[] scores = SuitScore(hand);

            for(int i = 0; i < scores.Length; i++)
            {
                if(scores[i] == 5)
                {
                    isFlush = true;
                }
            }

            return isFlush;
           
        }

        //evaluation if straight
        internal static Boolean IsStraight(Card [] hand)
        {
            Boolean isStraight = false;

            int [] scores = FaceScore(hand);
            //loop through face scores...look for 5 consectutive indices with score 1
            //only need to loop through first 8 indices...index 8 is highest starting index for a straight
            for(int i = 0; i <= 8; i++)
            {
                if(scores[i] == 1 && scores[i + 1] == 1 && scores[i + 2] == 1 && 
                    scores[i + 3] == 1 && scores[i + 4] == 1)
                {
                    isStraight = true;
                    break;
                }
            }

            return isStraight;
        }

        //evaluate if royal flush
        internal static Boolean IsRoyalFlush(Card [] hand)
        {
            //look if straight ends with ace, which is index 12
            int[] scores = FaceScore(hand);
            Boolean isRoyalFlush = (IsStraight(hand) && scores[12] == 1 && IsFlush(hand)) ?
                true : false;

            return isRoyalFlush;
        }

       
        
        //displayImage
        internal Image DisplayImage(Card card)
        {
            //add the imageName of the card to the end of the path
            Image image = Image.FromFile(path + card.ImageName());
            return image;

            
        }
    }

}
