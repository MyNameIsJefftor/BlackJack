using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Game
    {
        Hand Player { get; set; }
        Hand Dealer { get; set; }
        Deck deck { get; set; }
        public Game()
        {
            Player = new Hand();
            Dealer = new Hand();
            deck = new Deck();
        }
        
        public void GameStart()
        {
            deck.ShuffleDeck();

        }
    }
}
