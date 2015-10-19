using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_Game
{
   public class WordFile
   {
      private string[] words;

      private string _secretWord;
      public string SecretWord
      {
         get { return _secretWord; }
      }

      public void setSecretWord()
      {
         Random random = new Random();
         int randomNumber = random.Next(words.Length);
         _secretWord = words[randomNumber];
      }

      public WordFile()
      {
         string file = Properties.Resources.HangmanWords;
         words = file.Split('\n');

         for (int i = 0; i < words.Length; i++)
         {
            words[i] = words[i].TrimEnd();
         }
      }
   }
}
