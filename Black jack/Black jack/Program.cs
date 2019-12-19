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
            //Hand hand = new Hand();
            //deck.GenerateDeck();
            //bool exit = false;
            //while (!exit)
            //{
            //    Menus.MainMenu(deck, Hand, ref exit);
            //}
            //hand.AddCard(new Card("King", 10, "heart", 2665));
            //hand.AddCard(new Card("Jack", 10, "spade", 2660));
            //hand.AddCard(new Card("Ace", 11, "spade", 2660));
            //UI user = new UI();
            //user.PlayerCardView(hand);
            //Console.ReadKey();
            Game Start = new Game();
            bool exit = false;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            do
            {
                Console.Clear();
                Menus.launchmenu(Start, out exit);
            } while (!exit);
        }
    }
}
