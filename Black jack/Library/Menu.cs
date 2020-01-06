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
        private static string[] LaunchOptions = new string[] { "Play", "Shuffle and Display Deck", "Exit" };
        private static string[] HitStayOptions = new string[] { "Hit", "Stay" };
        private static string[] Replay = new string[] { "Yes", "No" };
        private static bool again = true;
        public static void launchmenu(Game game, out bool exit)
        {
            Console.WriteLine("xXx---- Kurtis Black Jack ----xXx");
            Readers.ReadChoice("Choice? : ", LaunchOptions, out int selection);
            switch (selection)
            {
                case (1):
                    game.Restart();
                    game.GameStart();
                    break;
                case (2):
                    game.ShowDeck();
                    break;
                case 3:
                    exit = true;
                    return;
            }
            if (again)
            {
                exit = false;
            }
            else
                exit = true;
        }
        public static void HitStay(Game game, out bool Hit)
        {
            Readers.ReadChoice("", HitStayOptions, out int selection);
            Console.CursorLeft = 0;
            if (selection == 1)
                Hit = true;
            else
                Hit = false;
        }

        internal static void Lose(UI userFace, Hand player, Hand dealer)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            userFace.WriteCenter($"You Lost!");
            userFace.WriteCenter($"You got {player.score}", 1);
            userFace.WriteCenter($"The dealer got {dealer.score}", 2);
            Console.ReadKey();
            PlayAgain();
        }

        internal static void Win(UI ui, Hand Player, Hand Dealer)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            ui.WriteCenter($"You won!");
            ui.WriteCenter($"You got {Player.score}", 1);
            ui.WriteCenter($"The dealer got {Dealer.score}", 2);
            Console.ReadKey();
            PlayAgain();
        }
        internal static void Draw(UI userFace, Hand player, Hand dealer)
        {
            Console.ForegroundColor = ConsoleColor.White;
            userFace.WriteCenter($"You Tied.");
            userFace.WriteCenter($"You got {player.score}", 1);
            userFace.WriteCenter($"The dealer got {dealer.score}", 2);
            Console.ReadKey();
            PlayAgain();
        }

        private static void PlayAgain()
        {
            Console.Clear();
            Console.ResetColor();
            Console.SetCursorPosition(0, 0);
            Readers.ReadChoice("Play again? : ", Replay, out int selection);
            switch (selection)
            {
                case 1:
                    again = true;
                    return;
                default:
                    again = false;
                    return;
            }
        }
    }
}