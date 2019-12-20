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
            Console.Clear();
            userFace.DealerCardView(Dealer, true);
            Console.ReadKey();
            userFace.PlayerCardView(Player);
            userFace.ScoreDisplay(Player);
            Console.ReadKey();
            bool Hit = false;
            do
            {
                Console.SetCursorPosition(0, userFace.centery);
                Menus.HitStay(this, out Hit);
                if (Hit)
                {
                    Player.draw(deck);
                }
                userFace.PlayerCardView(Player);
                userFace.ScoreDisplay(Player);
            } while (Hit && Player.score <= 21);
            Console.ReadKey();
            if (Player.score > 21)
            {
                Menus.Lose(userFace, Player, Dealer);
                return;
            }
            AI Go = new AI(Dealer, deck);
            userFace.DealerCardView(Dealer, false);
            Console.ReadKey();
            if (Dealer.score > 21)
            {
                Menus.Win(userFace, Player, Dealer);
                return;
            }
            ScoreCompare(Player, Dealer);
        }

        private void ScoreCompare(Hand player, Hand dealer)
        {
            if (player.score > dealer.score)
                Menus.Win(userFace, player, dealer);
            if (player.score == dealer.score)
                Menus.Draw(userFace, player, dealer);
            else
                Menus.Lose(userFace, player, dealer);
        }

        internal void Restart()
        {
            Player = new Hand();
            Dealer = new Hand();
            deck = new Deck();
            userFace = new UI();
        }

        public void ShowDeck()
        {
            userFace.CardView(deck);
            Console.ReadKey();
        }
    }
}
