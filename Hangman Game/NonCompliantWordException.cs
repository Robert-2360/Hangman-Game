// Final Project: Hangman Game
// Non Compliant Word Exception

using System;

namespace Hangman_Game
{
   class NonCompliantWordException : Exception
   {
      public NonCompliantWordException()
         : base("Secret Word does not comply with the game system rules") { }

      public NonCompliantWordException(string message) : base(message) { }

      public NonCompliantWordException(string message, Exception inner) : base(message, inner) { }
   }
}