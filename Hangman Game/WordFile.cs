// Final Project: Hangman Game
// Class WordFile
// Places a text file into a string array for the game

using System;

namespace Hangman_Game
{
   public class WordFile
   {
      private string[] words;

      public string SecretWord { get; set; }

      public WordFile()
      {
         string file = Properties.Resources.HangmanWords;
         words = file.Split('\n');

         // Removes the space at the end for each word
         for (int i = 0; i < words.Length; i++)
         {
            words[i] = words[i].TrimEnd();
         }
      }

      public void selectRandomSecretWord()
      {
         Random random = new Random();
         int randomNumber = random.Next(words.Length);
         SecretWord = words[randomNumber];
      }
   }
}