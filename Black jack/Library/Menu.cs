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
        private static string[] LaunchOptions = new string[] { "Play", "shuffle and display deck", "exit" };
        private static string[] HitStayOptions = new string[] { "Hit", "Stay" };
        private static string[] Replay = new string[] { "Yes", "No" };
        private static bool restart = false;
        private static bool again = false;
        public static void launchmenu(Game game, out bool exit)
        {
            Readers.ReadChoice("Choice? : ", LaunchOptions, out int selection);
            switch (selection)
            {
                case (1):
                    if (!restart)
                        restart = true;
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
            Console.CursorTop--;
            Console.Write(" ");
            if (selection == 1)
                Hit = true;
            else
                Hit = false;
        }

        internal static void Lose(UI userFace, Hand player, Hand dealer)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            userFace.WriteCenter($"You Lost!");
            userFace.WriteCenter($"You got {player.score}", 1);
            userFace.WriteCenter($"The dealer got {dealer.score}", 2);
            PlayAgain();
        }

        internal static void Win(UI ui, Hand Player, Hand Dealer)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            ui.WriteCenter($"You won!");
            ui.WriteCenter($"You got {Player.score}", 1);
            ui.WriteCenter($"The dealer got {Dealer.score}", 2);
            PlayAgain();
        }
        internal static void Draw(UI userFace, Hand player, Hand dealer)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            userFace.WriteCenter($"You Tied.");
            userFace.WriteCenter($"You got {player.score}", 1);
            userFace.WriteCenter($"The dealer got {dealer.score}", 2);
        }

        private static void PlayAgain()
        {
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