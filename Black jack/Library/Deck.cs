﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Deck
    {
        string[] suits = new string[] { "heart", "club", "spade", "diamond" };
        string[] faces = new string[] { "king", "queen", "Jack", "ten", "nine", "eight", "seven", "six", "five", "four", "three", "two", "Ace" };
        int[] Points = new int[] { 10, 10, 10, 10, 9, 8, 7, 6, 5, 4, 3, 2, 11 };

        public List<Card> deck { get; set; }
        public Deck()
        {
            deck = new List<Card>();
        }
        public void GenerateDeck()
        {
            new Deck();
            foreach (var suit in suits)
            {
                int i = 0;
                foreach (var face in faces)
                {
                    Card temp = new Card(face, Points[i++], suit);
                    deck.Add(temp);
                }
            }
        }
        public void DisplayDeck()
        {
            foreach(var card in this.deck)
            {
                Console.WriteLine(card.display());
            }
        }
        public void ShuffleDeck()
        {
            List<Card> temp = new List<Card>();
            Random randy = new Random();
            Console.WriteLine("Shuffle Start");
            while (temp.Count != deck.Count())
            {
                Card hold = deck[randy.Next(0, deck.Count)];
                if (!temp.Contains(hold))
                {
                    temp.Add(hold);
                }
            }
            deck = temp;
            Console.WriteLine("Shuffle done");
        }
        public Card dealCard()
        {
            Card temp = deck[0];
            deck.Remove(temp);
            return temp;
        }
    }
}
