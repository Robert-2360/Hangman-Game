// Final Project: Hangman Game
// Class WordFile
// Places a text file into a string array for the game

using System;
using System.Windows.Forms;

namespace Hangman_Game
{
   public class WordFile
   {
      // Declare variables
      private string _secretWord;
      private string[] words;

      // Initialize constants
      private const int MINIMUM_LENGTH = 4;
      private const int MAXIMUM_LENGTH = 9;

      // Property for _secretWord
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
               // Check if the word is long enough
               if (value.Length < MINIMUM_LENGTH)
               {
                  string message = string.Format("Length must be at least {0} characters long.", MINIMUM_LENGTH);
                  throw new NonCompliantWordException(message);
               }

               // Check if the word is too long
               else if (MAXIMUM_LENGTH < value.Length)
               {
                  string message = string.Format("Length must not be greater than {0} characters long.", MAXIMUM_LENGTH);
                  throw new NonCompliantWordException(message);
               }

               // Check if the word is all lower case characters
               else if (!isAllLowerCase(value))
               {
                  string message = string.Format("Word contains at least one non-lowercase character.");
                  throw new NonCompliantWordException(message);
               }

               // Set value as the new Secret Word
               else
               {
                  _secretWord = value;
               }
            }

            // Display message and terminate program
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

      // Loads a text file into an array
      public WordFile()
      {
         // Loads file into array
         string file = Properties.Resources.HangmanWords;
         words = file.Split('\n');

         // Removes the space at the end for each word
         for (int i = 0; i < words.Length; i++)
         {
            words[i] = words[i].TrimEnd();
         }
      }

      // Returns a randomly selected word from the array
      public string selectRandomSecretWord()
      {
         Random random = new Random();
         int randomNumber = random.Next(words.Length);
         return words[randomNumber];
      }

      // Returns true if all the characters in the given word are lowercase
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