using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Deck
    {
        string[] suits = new string[] { "club", "spade", "diamond", "heart" };
        int[] suitExit = new int[] { 2660, 2663, 2666, 2665 };
        string[] faces = new string[] { "King", "Queen", "Jack", "10", "9", "8", "7", "6", "5", "4", "3", "2", "Ace" };
        int[] Points = new int[] { 10, 10, 10, 10, 9, 8, 7, 6, 5, 4, 3, 2, 11 };

        public List<Card> deck { get; set; }
        public Deck()
        {
            deck = new List<Card>();
            GenerateDeck();
        }
        public void GenerateDeck()
        {
            int x = 0;
            foreach (var suit in suits)
            {
                int i = 0;
                foreach (var face in faces)
                {
                    Card temp = new Card(face, Points[i++], suit, suitExit[x]);
                    deck.Add(temp);
                }
                x++;
            }
        }
        public void DisplayDeck()
        {
            foreach (var card in this.deck)
            {
                Console.WriteLine(card.display());
            }
        }
        public void ShuffleDeck()
        {
            List<Card> temp = new List<Card>();
            Random randy = new Random();
            //Console.WriteLine("Shuffle Start");
            while (temp.Count != deck.Count())
            {
                Card hold = deck[randy.Next(0, deck.Count)];
                if (!temp.Contains(hold))
                {
                    temp.Add(hold);
                }
            }
            deck = temp;
            //Console.WriteLine("Shuffle done");
        }
        public Card dealCard()
        {
            Card temp = deck[0];
            deck.Remove(temp);
            return temp;
        }
    }
}
