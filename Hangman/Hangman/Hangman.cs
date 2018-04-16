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

