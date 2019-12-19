using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reader;

namespace Library
{
    public class Game
    {
        Hand Player { get; set; }
        Hand Dealer { get; set; }
        Deck deck { get; set; }
        UI userFace { get; set; }

        public Game()
        {
            Player = new Hand();
            Dealer = new Hand();
            deck = new Deck();
            userFace = new UI();

        }
        
        public void GameStart()
        {
            deck.ShuffleDeck();
            Dealer.draw(deck);
            Player.draw(deck);
            Dealer.draw(deck);
            Player.draw(deck);
            userFace.PlayerCardView(Player);

        }

        public void ShowDeck()
        {
            userFace.CardView(deck);
            Console.ReadKey();
        }
    }
}
