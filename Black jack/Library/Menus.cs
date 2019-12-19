using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reader;

namespace Library
{
    public class Menus
    {
        static string[] options;
        public static void MainMenu(Deck deck, Hand Hand, ref bool exit)
        {
            options = new string[] { "Display deck", "Shuffle deck", "Play(not implimented)", "exit" };
            Readers.ReadChoice("Your choice? : ", options, out int selection);
            switch (selection)
            {
                case 1:
                    deck.DisplayDeck();
                    break;
                case 2:
                    deck.ShuffleDeck();
                    break;
                case 3:
                    Hand.draw(deck);
                    Hand.draw(deck);
                    Hand.display();
                    Console.ReadKey();
                    break;
                case 4:
                    exit = true;
                    break;
            }
        }
    }
}