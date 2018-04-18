using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Hangman
    {
        static bool IsWord(string secretword, List<string> letterGuessed)
        {
            bool word = false;
            for (int i = 0; i < secretword.Length; i++)
            {
                string c = Convert.ToString(secretword[i]);
                if (letterGuessed.Contains(c))
                {
                    word = true;
                }
                else
                {
                    return word = false;
                }
            }
            return word;
        }
    }
}
static string Isletter(string secretword, List<string> letterGuessed)
{
    string correctletters = "";
    for (int i = 0; i < secretword.Length; i++)
    {
        string c = Convert.ToString(secretword[i]);
 
        if (letterGuessed.Contains(c))
        {
            correctletters += c;
        }
        else
        {
            correctletters += "_ ";
        }

    }
    return correctletters;
}

static void GetAlphabet(string letters)
{
    List<string> alphabet = new List<string>();

    for (int i = 1; i <= 26; i++)
    {
        char broski = Convert.ToChar(i + 96);
        alphabet.Add(Convert.ToString(broski));
    }
    int num = 49;
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("Letters Left are --->");

    for (int i = 0; i < num; i++)
    {
        if (letters.Contains(letters))
        {
            alphabet.Remove(letters);
            num -= 1;
        }
        Console.Write("[" + alphabet[i] + "] ");
    }

    Console.WriteLine();

}

