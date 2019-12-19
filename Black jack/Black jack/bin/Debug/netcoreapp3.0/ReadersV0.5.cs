using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reader
{
    public class Readers
    {
        //Reads a int and writes a prompt for the user.
        static public int ReadInteger(string Prompt)
        {
            string Uinput;
            int output = 0;
            while (true)
            {
                Console.Write(Prompt);
                Uinput = Console.ReadLine();
                if (int.TryParse(Uinput, out output) && output >= 0)
                {
                    break;
                }
                Console.Clear();
                Console.WriteLine("Try again...");
            }
            return output;
        }
        //Same as ReadInteger, but now has a Min Max
        static public int ReadIntegerWMM(string Prompt, int min, int max)
        {
            string Uinput;
            int output = 0;
            while (true)
            {
                Console.Write(Prompt);
                Uinput = Console.ReadLine();
                if (int.TryParse(Uinput, out output) && min <= output && output <= max)
                {
                    break;
                }
                Console.Clear();
                Console.WriteLine($"Number must be between {min} and {max}. Try again...");
            }
            return output;
        }
        //Reads a string input and writes a prompt for the user.
        static public string ReadString(string Prompt)
        {
            string Uinput;
            string output;
            while (true)
            {
                Console.Write(Prompt);
                Uinput = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(Uinput))
                {
                    output = Uinput;
                    break;
                }
                Console.Clear();
                Console.WriteLine("You must enter something. Try again...");
            }
            return output;
        }
        //Similar to ReadString, but now edits a ref.
        static public void ReadStringRef(string Prompt, ref string value)
        {
            string Uinput;
            while (true)
            {
                Console.Write(Prompt);
                Uinput = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(Uinput))
                {
                    value = Uinput;
                    break;
                }
                Console.Clear();
                Console.WriteLine("You must enter something. Try again...");
            }
        }
        //Prints a list of options and then accepts an input, by using IntegerWMM.
        static public void ReadChoice(string prompt, string[] options, out int selection)
        {
                for (int i = 0; i < options.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {options[i]}");
                }
                selection = ReadIntegerWMM(prompt, 1, options.Length);
        }
    }
}

  