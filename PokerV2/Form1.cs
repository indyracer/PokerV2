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

        Card[] hand = new Card[5];
        //path to get images
        public const string path = @"C:\\Users\\bobco\\source\\repos\\PokerV2\\PokerV2\\Resources\\";
        //Array to hold pictures of cards
        Image[] cardImages;
        //creates Deck for playing
        static Deck deck;
        //array to hold player hands
        Card[][] playerHands;
        //hold previous hand's number of players, used to clear if needed
        int previousHandPLayers;
        int numPlayers = 0;
        


        public void label2_Click (object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
        }


        public void ShuffleButton_Click(object sender, EventArgs e)
        {
            //clear previous hand's values 
            evaluationLabel.Text = "";
            player1Evaluation.Text = "";
            player2Evaluation.Text = "";

            player1Card1.Text = "";
            player1Card2.Text = "";
            player1Card3.Text = "";
            player1Card4.Text = "";
            player1Card5.Text = "";

            player1Pic1.Image = null;
            player1Pic2.Image = null;
            player1Pic3.Image = null;
            player1Pic4.Image = null;
            player1Pic5.Image = null;

            player2Card1.Text = "";
            player2Card2.Text = "";
            player2Card3.Text = "";
            player2Card4.Text = "";
            player2Card5.Text = "";

            player2Pic1.Image = null;
            player2Pic2.Image = null;
            player2Pic3.Image = null;
            player2Pic4.Image = null;
            player2Pic5.Image = null;

            deck = new Deck(); //creates new deck when shuffling


            //start new hand
            try
            {
                numPlayers = Int32.Parse(numOfPlayers.Text);

                if (numPlayers > 2 || numPlayers < 0)
                {
                    MessageBox.Show("Please input 1 or 2 players");
                }
                else
                {

                    previousHandPLayers = numPlayers;
                    //deal hands to each player
                    //array of player hands
                    playerHands = new Card[numPlayers][];


                    deck.Shuffle();


                    for (int x = 0; x < numPlayers; x++)
                    {
                        Card[] player = DealHands();
                        playerHands[x] = player;
                    }


                    player1Card1.Text = playerHands[0][0].DisplayCard();
                    player1Card2.Text = playerHands[0][1].DisplayCard();
                    player1Card3.Text = playerHands[0][2].DisplayCard();
                    player1Card4.Text = playerHands[0][3].DisplayCard();
                    player1Card5.Text = playerHands[0][4].DisplayCard();

                    player1Pic1.Image = DisplayImage(playerHands[0][0]);
                    player1Pic2.Image = DisplayImage(playerHands[0][1]);
                    player1Pic3.Image = DisplayImage(playerHands[0][2]);
                    player1Pic4.Image = DisplayImage(playerHands[0][3]);
                    player1Pic5.Image = DisplayImage(playerHands[0][4]);

                    if (numPlayers == 2)
                    {
                        player2Card1.Text = playerHands[1][0].DisplayCard();
                        player2Card2.Text = playerHands[1][1].DisplayCard();
                        player2Card3.Text = playerHands[1][2].DisplayCard();
                        player2Card4.Text = playerHands[1][3].DisplayCard();
                        player2Card5.Text = playerHands[1][4].DisplayCard();

                        player2Pic1.Image = DisplayImage(playerHands[1][0]);
                        player2Pic2.Image = DisplayImage(playerHands[1][1]);
                        player2Pic3.Image = DisplayImage(playerHands[1][2]);
                        player2Pic4.Image = DisplayImage(playerHands[1][3]);
                        player2Pic5.Image = DisplayImage(playerHands[1][4]);
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Please input 1 or 2 players");
            }
        }

        public void evaluationButton_Click(object sender, EventArgs e)
        {
            //call methods to evaluate hand here
            //need to put in exception handling...how to handle if no hands dealt?


            try
            {
                int numPlayers = Int32.Parse(numOfPlayers.Text);

                player1Evaluation.Text = EvaluateHand(playerHands[0]);

                if (numPlayers == 2)
                {
                    player2Evaluation.Text = EvaluateHand(playerHands[1]);

                    int player1Points = PlayerHandPoints(playerHands[0]);
                    int player2Points = PlayerHandPoints(playerHands[1]);

                    if (player1Points > player2Points)
                    {
                        evaluationLabel.Text = "Player 1's " + player1Evaluation.Text +
                            " beats Player 2's " + player2Evaluation.Text;
                    }
                    else if (player2Points > player1Points)
                    {
                        evaluationLabel.Text = "Player 2's " + player2Evaluation.Text +
                           " beats Player 1's " + player1Evaluation.Text;
                    }
                    else //tie...ceck highcard for winner..need to work on additional logic
                    //scenario:  pair of tens...high card is less than 10.  Need to figure out that logic
                    {
                        int tieRank = player1Points; //already determined it's a tie.  Need to know what type of rank
                                              

                        if (tieRank == 0 || tieRank == 4 || tieRank == 8)
                        {
                            evaluationLabel.Text = TieEvalHighStraight(playerHands[0], playerHands[1]);
                        }
                        else if (tieRank == 1)
                        {
                            evaluationLabel.Text = TieEvalPair(playerHands[0], playerHands[1]);
                        }

                         else
                            evaluationLabel.Text = "Tie hand....working on tie hand evaluation functionality";
                        
                    }
                }
            } catch(Exception ex)
            {
                MessageBox.Show("Make sure to deal a hand first!");
            }

            
        }

        
        //evaluate hands
        internal static string EvaluateHand(Card[] hand)
        {
            string evaluation = "";

            if (IsPair(hand))
            {
                evaluation = "Pair";
            }
            else if (IsTwoPair(hand))
            {
                evaluation = "Two Pair";
            }
            else if (IsThreeOfKind(hand))
            {
                evaluation = "Three of a Kind";
            }
            else if (IsFourOfKind(hand))
            {
                evaluation = "Four of Kind";
            }
            else if (IsFullHouse(hand))
            {
                evaluation = "Full House";
            }
            else if (IsStraight(hand) && !IsFlush(hand))
            {
                evaluation = "Straight";
            }
            else if (IsStraight(hand) && IsFlush(hand) && !IsRoyalFlush(hand))
            {
                evaluation = "Straight Flush";
            }
            else if (IsRoyalFlush(hand))
            {
                evaluation = "Royal Flush";
            }
            else if (IsFlush(hand))
            {
                evaluation = "Flush";
            }
            else
            {
                evaluation = "High Card";
            }

            return evaluation;
        }

        //assign point value to hand, so you can evaluate which player had higher hand
        internal static int PlayerHandPoints (Card[] hand)
        {
            String playerResult = EvaluateHand(hand);
            int playerPoint = 0;
            switch (playerResult)
            {
                case "Pair":
                    playerPoint = 1;
                    break;
                case "Two Pair":
                    playerPoint = 2;
                    break;
                case "Three of a Kind":
                    playerPoint = 3;
                    break;
                case "Straight":
                    playerPoint = 4;
                    break;
                case "Flush":
                    playerPoint = 5;
                    break;
                case "Full House":
                    playerPoint = 6;
                    break;
                case "Four of a Kind":
                    playerPoint = 7;
                    break;
                case "Straight Flush":
                    playerPoint = 8;
                    break;
                case "Royal Flush":
                    playerPoint = 9;
                    break;
                default:
                    playerPoint = 0;
                    break;
            }
            return playerPoint;
        }


        //deal hands 
        //need to rethink if this is right place to shuffle with multiple players.  
        //potential for same card to be in 2 hands.
        internal static Card[] DealHands()
        {
            Card[] hand = new Card[5];

            //deck.Shuffle();

            hand[0] = deck.DealCard();
            hand[1] = deck.DealCard();
            hand[2] = deck.DealCard();
            hand[3] = deck.DealCard();
            hand[4] = deck.DealCard();

            return hand;

        }

        //methods used to evaluate hands

        //calculate suit score, place in array
        internal static int[] SuitScore(Card[] hand)
        {
            int diamondScore = 0, spadeScore = 0, heartScore = 0, clubScore = 0;

            for (int i = 0; i < hand.Length; i++)
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
        internal static int[] FaceScore(Card[] hand)
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
        internal static Boolean IsPair(Card[] hand)
        {
            Boolean isPair = false;
            int[] score = FaceScore(hand);
            //run through hand, check if only 1 faceScore == 2 and 3 other faceScores == 1
            int countTwo = 0, countOne = 0, countOther = 0;
            for (int i = 0; i < score.Length; i++)
            {
                if (score[i] == 2)
                {
                    countTwo++;
                }
                else if (score[i] == 1) {
                    countOne++;
                }
                else
                {
                    countOther++;
                }
            }

            if (countTwo == 1 && countOne == 3)
            {
                isPair = true;
            }

            return isPair;
        }

        //evaluate hand, check if two pair
        internal static Boolean IsTwoPair(Card[] hand)
        {
            Boolean isTwoPair = false;
            int countTwo = 0, countOne = 0, countOther = 0;
            //place face scores in an array.  Looking for countTwo == 2, countOne == 1 
            int[] scores = FaceScore(hand);

            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i] == 2)
                {
                    countTwo++;
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

            if (countTwo == 2 && countOne == 1)
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

            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i] == 3)
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

            if (countThree == 1 && countOne == 2)
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
            int[] scores = FaceScore(hand);

            int countFour = 0, countOne = 0, countOther = 0;

            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i] == 4)
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

            if (countFour == 1 && countOne == 1)
            {
                isFourKind = true;
            }

            return isFourKind;
        }

        //evaluate if Full House START HERE
        internal static Boolean IsFullHouse(Card[] hand)
        {
            //look at scores...looking for 1 count == 3, 1 count == 2
            Boolean isFullHouse = false;
            int[] scores = FaceScore(hand);
            int countTwo = 0, countThree = 0, countOther = 0;

            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i] == 2)
                {
                    countTwo++;
                }
                else if (scores[i] == 3)
                {
                    countThree++;
                }
                else
                {
                    countOther++;
                }
            }

            if (countTwo == 1 && countThree == 1)
            {
                isFullHouse = true;
            }

            return isFullHouse;
        }

        //evaluate if flush
        internal static Boolean IsFlush(Card[] hand)
        {
            Boolean isFlush = false;
            int[] scores = SuitScore(hand);

            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i] == 5)
                {
                    isFlush = true;
                }
            }

            return isFlush;

        }

        //evaluation if straight
        internal static Boolean IsStraight(Card[] hand)
        {
            Boolean isStraight = false;

            int[] scores = FaceScore(hand);
            //loop through face scores...look for 5 consectutive indices with score 1
            //only need to loop through first 8 indices...index 8 is highest starting index for a straight
            for (int i = 0; i <= 8; i++)
            {
                if (scores[i] == 1 && scores[i + 1] == 1 && scores[i + 2] == 1 &&
                    scores[i + 3] == 1 && scores[i + 4] == 1)
                {
                    isStraight = true;
                    break;
                }
            }

            return isStraight;
        }

        //evaluate if royal flush
        internal static Boolean IsRoyalFlush(Card[] hand)
        {
            //look if straight ends with ace, which is index 12
            int[] scores = FaceScore(hand);
            Boolean isRoyalFlush = (IsStraight(hand) && scores[12] == 1 && IsFlush(hand)) ?
                true : false;

            return isRoyalFlush;
        }


        //evaluate tie hands
        //high card, straight, straight flush
        internal static String TieEvalHighStraight(Card[] hand1, Card[] hand2)
        {
            int[] hand1Scores = FaceScore(hand1);
            int[] hand2Scores = FaceScore(hand2);
            string message = "Tie...hands have the same value";

            for(int i = hand1Scores.Length - 1; i >= 0; i--)
            {
                if(hand1Scores[i] > hand2Scores[i])
                {
                    
                    message = "Tie...Player 1 wins with high card";
                    break;
                }
                else if(hand1Scores[i] < hand2Scores[i])
                {
                    message =  "Tie...Player 2 wins with high card";
                    break;

                }

            }

            return message;
        }

        internal static String TieEvalPair(Card [] hand1, Card [] hand2)
        {
            int[] hand1Scores = FaceScore(hand1);
            int[] hand2Scores = FaceScore(hand2);
            string message = "Tie...hands have the same value";


            //look for highest value of 2 in indices
            if(Array.LastIndexOf(hand1Scores, 2) > Array.LastIndexOf(hand2Scores, 2))
            {
                message = "Tie...Player 1 wins with higher Pair";
            } else if(Array.LastIndexOf(hand1Scores, 2) < Array.LastIndexOf(hand2Scores, 2))
            {
                message = "Tie..Player 2 wins with higher Pair";
            } else
            {
                //pairs are of same value...so need to check high cards
               for(int i = hand1Scores.Length - 1; i >= 0; i--)
                {
                    if(hand1Scores[i] == 1 || hand2Scores[i] == 1)
                    {
                        if(hand1Scores[i] > hand2Scores[i])
                        {
                            message = "Tie...Player 1 wins with high card";
                        } else if(hand1Scores[i] < hand2Scores[i])
                        {
                            message = "Tie...Player 2 wins with high card";
                        }
                    }
                }
            }

            return message;
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
