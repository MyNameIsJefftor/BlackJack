using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reader;

namespace Library
{
    static public class Menus
    {
        static string[] LaunchOptions = new string[] { "Play", "shuffle and display deck", "exit" };
        public static void launchmenu(Game game, out bool exit)
        {
            Readers.ReadChoice("Choice? : ", LaunchOptions, out int selection);
            switch (selection)
            {
                case (1):
                    game.GameStart();
                    break;
                case (2):
                    game.ShowDeck();
                    break;
                case 3:
                    exit = true;
                    return;
            }
            exit = false;
        }
    }
}