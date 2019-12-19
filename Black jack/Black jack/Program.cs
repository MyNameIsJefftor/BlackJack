using System;
using System.Collections.Generic;
using Library;

namespace Black_jack
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deck deck = new Deck();
            Hand hand = new Hand();
            //deck.GenerateDeck();
            //bool exit = false;
            //while (!exit)
            //{
            //    Menus.MainMenu(deck, Hand, ref exit);
            //}
            hand.AddCard(new Card("Ace", 11, "heart"));
            hand.AddCard(new Card("Jack", 10, "spade"));
            hand.AddCard(new Card("Ace", 11, "spade"));
            UI user = new UI();
            user.CardView(hand);
            Console.ReadKey();
        }
    }
}
