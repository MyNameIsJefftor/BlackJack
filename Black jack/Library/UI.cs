
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class UI
    {
        public int centerx { get; private set; }
        public int centery { get; private set; }
        int consoleW { get; set; }
        int consoleH { get; set; }
        string Space = " ";
        ConsoleColor SpadeClub = ConsoleColor.DarkCyan;
        ConsoleColor HeartDiamond = ConsoleColor.Magenta;
        public UI()
        {
            consoleW = Console.WindowWidth;
            consoleH = Console.WindowHeight;
            centerx = consoleW / 2;
            centery = consoleH / 2;
        }
        public void WriteCenter(string Write)
        {
            Console.SetCursorPosition(centerx - (Write.Length/2), centery);
            Console.Write(Write);
        }
        public void WriteCenter(string Write, int i)
        {
            Console.SetCursorPosition(centerx - (Write.Length / 2), centery+i);
            Console.Write(Write);
        }
        #region DeckViewer
        public void CardView(Deck deck)
        {
            int i = 0;
            Console.Clear();
            foreach (var card in deck.deck)
            {
                if (card.Suit == "heart" || card.Suit == "diamond")
                {
                    GenerateCard(HeartDiamond, card, i);
                }
                else
                {
                    GenerateCard(SpadeClub, card, i);
                }
            }
            Console.ResetColor();
        }
        private void GenerateCard(ConsoleColor suit, Card card, int count)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = suit;
            Console.Write(card.display());
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine('\n');

        }
        #endregion
        #region Player Cards
        public void PlayerCardView(Hand hand)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            int i = 0;
            foreach (var card in hand.handCards)
            {
                if (card.Suit == "heart" || card.Suit == "diamond")
                {
                    GeneratePlayerCard(HeartDiamond, card, i);
                }
                else
                {
                    GeneratePlayerCard(SpadeClub, card, i);
                }
                i++;
            }

        }
        //displays card on the players side of the table
        private void GeneratePlayerCard(ConsoleColor suit, Card card, int count)
        {
            Console.ForegroundColor = suit;
            int cardWidth = (int)(consoleW * .1);
            int cardHeight = consoleH - 6;
            for (int hi = cardHeight; hi < consoleH; hi++)
            {
                Console.SetCursorPosition(cardWidth + (count * (cardWidth+1)), hi);
                for (int i = 0; i < cardWidth; i++)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    if (hi == cardHeight && i == 0)
                    {
                        switch (card.SuitSymb)
                        {
                            case 2660:
                                Console.Write("\u2660");
                                break;
                            case 2663:
                                Console.Write("\u2663");
                                break;
                            case 2666:
                                Console.Write("\u2666");
                                break;
                            case 2665:
                                Console.Write("\u2665");
                                break;
                        }
                        i++;
                    }
                    if (hi == cardHeight && i == 1)
                    {
                        Console.Write(card.Face);
                        i += card.Face.Length - 1;
                    }
                    else
                        Console.Write(Space);
                }
            }
            Console.ResetColor();
        }
        #endregion
        #region Dealer Cards
        public void DealerCardView(Hand hand, bool hide)
        {
            int i = 0;
            foreach (var card in hand.handCards)
            {
                if (card.Suit == "heart" || card.Suit == "diamond")
                {
                    GenerateDealerCard(HeartDiamond, card, i, hide);
                }
                else
                {
                    GenerateDealerCard(SpadeClub, card, i, hide);
                }
                i++;
            }

        }
        private void GenerateDealerCard(ConsoleColor suit, Card card, int count, bool hide)
        {
            Console.ForegroundColor = suit;
            int cardWidth = (int)(consoleW * .1);
            int cardHeight = consoleH - 5;
            for (int hi = 0; hi < 5 + 1; hi++)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(cardWidth + (count * (cardWidth + 1)), hi);
                for (int i = 0; i < cardWidth; i++)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    if (count == 1 && hide)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                    }
                    if (hi == 5 && i == 0)
                    {
                        switch (card.SuitSymb)
                        {
                            case 2660:
                                Console.Write("\u2660");
                                break;
                            case 2663:
                                Console.Write("\u2663");
                                break;
                            case 2666:
                                Console.Write("\u2666");
                                break;
                            case 2665:
                                Console.Write("\u2665");
                                break;
                        }
                        i++;
                    }
                    if (hi == 5 && i == 1)
                    {
                        Console.Write(card.Face);
                        i += card.Face.Length - 1;
                    }
                    else
                        Console.Write(Space);
                }
            }
            Console.ResetColor();
        }
        #endregion
        #region Score Display
        public void ScoreDisplay(Hand hand)
        {
            Console.SetCursorPosition((int)(consoleW * .1), (consoleH - 8));
            Console.Write(hand.score);
        }
        #endregion
    }
}
