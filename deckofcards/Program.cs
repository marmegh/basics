using System;
using System.Collections.Generic;

namespace deckofcards
{
    class Program
    {
        public static Random rand = new Random();        
        public class Card
        {
            public string stringVal;
            public string suit;
            public int val;
            string[] cardvs = {"joker", "ace", "two", "three", "four","five", "six", "seven", "eight", "nine","ten", "jack", "queen", "king"};
            string[] cardsuits = {"hearts", "diamonds", "spades", "clubs"};
            public Card(int csuit,int cval)
            {
                if(csuit <= 3 && cval <=13)
                {
                   val = cval;
                    suit = cardsuits[csuit];
                    stringVal = cardvs[val]; 
                }
                else
                {
                    val = 0;
                    suit = "bicycle";
                    stringVal = "joker";
                }
            }            
        }
        public class Deck
        {
            List<Card> cards = new List<Card>();
            List<Card> discards = new List<Card>();

            public Deck()
            {
                for(int i = 1; i < 14; i++)
                {
                    for(int j = 0; j<4; j++)
                    {
                        Card temp = new Card(j, i);
                        cards.Add(temp);
                    }
                }
            }            
            public void Shuffle()
            {
                for(int t = 0; t < cards.Count; t++)
                {
                    Card tmp = cards[t];
                    int r = rand.Next(t, cards.Count);
                    cards[t] = cards[r];
                    cards[r] = tmp;
                }
            }
            public Card Deal()
            {
                Card temp = cards[0];
                discards.Add(temp);
                cards.RemoveAt(0);
                return temp;
            }
            public void Restore()
            {
                for(int i = 0; i< discards.Count; i++)
                {
                    cards.Add(discards[i]);
                    discards.RemoveAt(i);
                }
            }
        }
        public class Player
        {
            string name;
            List<Card> hand = new List<Card>();
            public List<Card> fillHand(Deck game)
            {
                while (hand.Count < 5)
                {
                    Card temp = Draw(game);
                    System.Console.WriteLine("{0} of {1}", temp.stringVal, temp.suit);
                }
                return hand;
            }
            public Player(string newName, Deck game)
            {
                name = newName;
                hand = fillHand(game);
            }
            public Card Draw(Deck game)
            {
                hand.Add(game.Deal());
                return hand[hand.Count - 1];
            }
            public Card Discard(int idx)
            {
                System.Console.WriteLine(hand.Count);
                if(idx < hand.Count){
                    Card temp = hand[idx];
                    hand.RemoveAt(idx);
                    return temp;
                }
                else{
                    return null;
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("It's time to play a game...");
            Deck game = new Deck();
            game.Shuffle();
            Player person = new Player("Tom", game);
            person.Discard(0);
            person.Discard(0);
            person.Discard(0);
            person.Discard(0);
            person.Discard(0);
            person.Discard(0);
        }
    }
}
