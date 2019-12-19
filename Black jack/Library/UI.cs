
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
        ConsoleColor SpadeClub = ConsoleColor.Blue;
        ConsoleColor HeartDiamond = ConsoleColor.Red;
        public UI()
        {
            consoleW = Console.WindowWidth;
            consoleH = Console.WindowHeight;
            centerx = consoleW / 2;
            centery = consoleH / 2;
        }
        public void WriteCenter(string Write)
        {
            Console.SetCursorPosition(centerx - Write.Length, centery);
            Console.Write(Write);
        }
        public void CardView(Hand hand)
        {
            foreach (var card in hand.handCards)
            {
                if (card.Suit == "heart" || card.Suit == "diamond")
                {
                    GenerateCard(HeartDiamond, card);
                }
                else
                {
                    GenerateCard(SpadeClub, card);
                }
            }

        }

        private void GenerateCard(ConsoleColor suit, Card card)
        {
            Console.SetCursorPosition((int)(consoleW * .15), consoleH-10);
            for (int hi = consoleH - 10; hi <= consoleH; hi++)
            {
                for (int i = 0; i < (consoleW * .15); i++)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Write(Space);
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                Console.SetCursorPosition((int)(consoleW * .15), hi);
            }
        }
    }
}
