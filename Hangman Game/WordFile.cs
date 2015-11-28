// Final Project: Hangman Game
// Class WordFile
// Places a text file into a string array for the game

using System;
using System.Windows.Forms;

namespace Hangman_Game
{
   public class WordFile
   {
      private string _secretWord;
      private string[] words;
      private int minimumLength = 4;
      private int maximumLength = 9;

      public string SecretWord
      {
         get
         {
            return _secretWord;
         }

         set
         {
            try
            {
               if (value.Length < minimumLength)
               {
                  string message = string.Format("Length must be at least {0} characters long.", minimumLength);
                  throw new NonCompliantWordException(message);
               }
               if (maximumLength < value.Length)
               {
                  string message = string.Format("Length must not be greater than {0} characters long.", maximumLength);
                  throw new NonCompliantWordException(message);
               }
               if (!isAllLowerCase(value))
               {
                  string message = string.Format("Word contains at least one non-lowercase character.");
                  throw new NonCompliantWordException(message);
               }
               else
               {
                  _secretWord = value;
               }
            }
            catch (NonCompliantWordException ex)
            {
               string message =
                  string.Format("Secret Word: {0}\n {1}\n Please correct this and rebuild.\n Program will now exit.",
                  value, ex.Message);
               MessageBox.Show(message);
               Application.Exit();
            }
         }
      }

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

      // Returns true if all the characters in the given word are lower case
      public bool isAllLowerCase(string word)
      {
         bool result = true;
         foreach (char c in word)
         {
            if (!Char.IsLower(c))
            {
               result = false;
               break;
            }
         }
         return result;
      }
   }
}