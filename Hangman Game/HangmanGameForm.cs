// Final Project: Hangman Game
// Class: HangmanGameForm

using System;
using System.Drawing;
using System.Windows.Forms;

namespace Hangman_Game
{
   public partial class HangmanGameForm : Form
   {
      public HangmanGameForm()
      {
         InitializeComponent();
      }

      // Declare wordFile reference
      private WordFile wordFile;

      // Declare web link reference
      LinkLabel.Link link;

      // Declare array references
      private Label[] wordLabels;
      private Button[] charButtons;
      private Image[] hangingManImages;
      private Image[] instructionImages;

      // Declare int variables
      private int lettersRemainingCounter;
      private int lettersWrongCounter;
      private int instructionImageCounter;
      private int numberOfGamesWon;
      private int numberOfGamesLost;

      // Initialize int constants
      private const int MAXIMUM_WORD_SIZE = 9;
      private const int NUMBER_OF_BUTTONS = 26;
      private const int NUMBER_OF_HANGMAN_IMAGES = 8;
      private const int MAXIMUM_WRONG_CHOICES = 7;
      private const int NUMBER_OF_INSTRUCTION_IMAGES = 4;
      private const int TEXT_SOURCE_IMAGE = 1;
      private const int GIVE_ME_A_HINT_IMAGE = 3;

      // Initialize Color constants
      private readonly Color RED = Color.FromArgb(255, 232, 235);
      private readonly Color GREEN = Color.FromArgb(202, 234, 189);

      // When game form is first loaded, initialize variables, and display "welcome"
      private void HangmanGameForm_Load(object sender, EventArgs e)
      {
         // Initialize variables
         wordFile = new WordFile();
         link = new LinkLabel.Link();
         nextInstructionButton.Visible = false;
         giveUpToolStripMenuItem.Visible = false;
         giveMeAHintToolStripMenuItem.Visible = false;
         numberOfGamesWon = 0;
         numberOfGamesLost = 0;

         // Add link data
         link.LinkData = "http://introcs.cs.princeton.edu/java/data/1000words.txt";
         textSourceLink.Links.Add(link);

         // Initialize label array for SecretWord display
         wordLabels = new Label[MAXIMUM_WORD_SIZE];
         wordLabels[0] = wordChar0;
         wordLabels[1] = wordChar1;
         wordLabels[2] = wordChar2;
         wordLabels[3] = wordChar3;
         wordLabels[4] = wordChar4;
         wordLabels[5] = wordChar5;
         wordLabels[6] = wordChar6;
         wordLabels[7] = wordChar7;
         wordLabels[8] = wordChar8;

         // Initialize button array for letter choice box
         charButtons = new Button[NUMBER_OF_BUTTONS];
         charButtons[0] = aCharButton;
         charButtons[1] = bCharButton;
         charButtons[2] = cCharButton;
         charButtons[3] = dCharButton;
         charButtons[4] = eCharButton;
         charButtons[5] = fCharButton;
         charButtons[6] = gCharButton;
         charButtons[7] = hCharButton;
         charButtons[8] = iCharButton;
         charButtons[9] = jCharButton;
         charButtons[10] = kCharButton;
         charButtons[11] = lCharButton;
         charButtons[12] = mCharButton;
         charButtons[13] = nCharButton;
         charButtons[14] = oCharButton;
         charButtons[15] = pCharButton;
         charButtons[16] = qCharButton;
         charButtons[17] = rCharButton;
         charButtons[18] = sCharButton;
         charButtons[19] = tCharButton;
         charButtons[20] = uCharButton;
         charButtons[21] = vCharButton;
         charButtons[22] = wCharButton;
         charButtons[23] = xCharButton;
         charButtons[24] = yCharButton;
         charButtons[25] = zCharButton;

         // Initialize image array for hangman drawing sections
         hangingManImages = new Image[NUMBER_OF_HANGMAN_IMAGES];
         hangingManImages[0] = Properties.Resources.Man0;
         hangingManImages[1] = Properties.Resources.Man1;
         hangingManImages[2] = Properties.Resources.Man2;
         hangingManImages[3] = Properties.Resources.Man3;
         hangingManImages[4] = Properties.Resources.Man4;
         hangingManImages[5] = Properties.Resources.Man5;
         hangingManImages[6] = Properties.Resources.Man6;
         hangingManImages[7] = Properties.Resources.DeadMan;

         // Initialize image array for instruction images
         instructionImages = new Image[NUMBER_OF_INSTRUCTION_IMAGES];
         instructionImages[0] = Properties.Resources.Instructions0;
         instructionImages[1] = Properties.Resources.Instructions1;
         instructionImages[2] = Properties.Resources.Instructions2;
         instructionImages[3] = Properties.Resources.Instructions3;

         // Display "welcome" in wordLabel array
         clearSecretWordDisplay();
         wordFile.SecretWord = "welcome";
         makeBlankDisplayVisible();
         displaySecretWord();
      }

      // The following 26 methods are for each letter button
      private void aCharButton_Click(object sender, EventArgs e) { buttonClicked(aCharButton); }
      private void bCharButton_Click(object sender, EventArgs e) { buttonClicked(bCharButton); }
      private void cCharButton_Click(object sender, EventArgs e) { buttonClicked(cCharButton); }
      private void dCharButton_Click(object sender, EventArgs e) { buttonClicked(dCharButton); }
      private void eCharButton_Click(object sender, EventArgs e) { buttonClicked(eCharButton); }
      private void fCharButton_Click(object sender, EventArgs e) { buttonClicked(fCharButton); }
      private void gCharButton_Click(object sender, EventArgs e) { buttonClicked(gCharButton); }
      private void hCharButton_Click(object sender, EventArgs e) { buttonClicked(hCharButton); }
      private void iCharButton_Click(object sender, EventArgs e) { buttonClicked(iCharButton); }
      private void jCharButton_Click(object sender, EventArgs e) { buttonClicked(jCharButton); }
      private void kCharButton_Click(object sender, EventArgs e) { buttonClicked(kCharButton); }
      private void lCharButton_Click(object sender, EventArgs e) { buttonClicked(lCharButton); }
      private void mCharButton_Click(object sender, EventArgs e) { buttonClicked(mCharButton); }
      private void nCharButton_Click(object sender, EventArgs e) { buttonClicked(nCharButton); }
      private void oCharButton_Click(object sender, EventArgs e) { buttonClicked(oCharButton); }
      private void pCharButton_Click(object sender, EventArgs e) { buttonClicked(pCharButton); }
      private void qCharButton_Click(object sender, EventArgs e) { buttonClicked(qCharButton); }
      private void rCharButton_Click(object sender, EventArgs e) { buttonClicked(rCharButton); }
      private void sCharButton_Click(object sender, EventArgs e) { buttonClicked(sCharButton); }
      private void tCharButton_Click(object sender, EventArgs e) { buttonClicked(tCharButton); }
      private void uCharButton_Click(object sender, EventArgs e) { buttonClicked(uCharButton); }
      private void vCharButton_Click(object sender, EventArgs e) { buttonClicked(vCharButton); }
      private void wCharButton_Click(object sender, EventArgs e) { buttonClicked(wCharButton); }
      private void xCharButton_Click(object sender, EventArgs e) { buttonClicked(xCharButton); }
      private void yCharButton_Click(object sender, EventArgs e) { buttonClicked(yCharButton); }
      private void zCharButton_Click(object sender, EventArgs e) { buttonClicked(zCharButton); }

      // Actions performed when a letter button is clicked
      private void buttonClicked(Button b)
      {
         // Reset letter found variable
         bool letterFound = false;

         // Disable the chosen button
         b.Enabled = false;
         b.BackColor = RED;

         // If letter selected is present in SecretWord, make that letter visible
         for (int i = 0; i < wordFile.SecretWord.Length; i++)
         {
            // Initialize char variables for comparison
            char charInSecretWord = wordFile.SecretWord[i];
            char charOnButtonSelected = Convert.ToChar(b.Text);

            // Check if SecretWord character matches button seleted character
            if (charInSecretWord == charOnButtonSelected)
            {
               // Assign correct letter choice to proper blank wordLabel array slot
               // Note: This will make the correct choice visible
               wordLabels[i].Text = b.Text;

               // Update counter
               lettersRemainingCounter--;

               // Set letterFound to true
               letterFound = true;
            }
         }

         // If letter selected was wrong then:
         if (!letterFound)
         {
            // Increment counter
            lettersWrongCounter++;

            // Display next hangman image
            drawingPictureBox.Image = hangingManImages[lettersWrongCounter];

            // If eligible for a hint, make menu button visible
            if (lettersWrongCounter == MAXIMUM_WRONG_CHOICES - 1 && lettersRemainingCounter > 1)
            {
               giveMeAHintToolStripMenuItem.Visible = true;
            }
         }

         // Update status label
         statusLabel.Text = string.Format("Letters Remaining: {0} Wrong: {1}",
            lettersRemainingCounter, lettersWrongCounter);

         // Determine if game has been won
         if (lettersRemainingCounter == 0)
         {
            numberOfGamesWon++;
            statusLabel.Text = string.Format("You won!       Won: {0} Lost: {1}",
               numberOfGamesWon, numberOfGamesLost);
            giveUpToolStripMenuItem.Visible = false;
            drawingPictureBox.Image = Properties.Resources.AliveMan;
            disableLetterButtons();
         }

         // Determine if game has been lost
         if (lettersWrongCounter == MAXIMUM_WRONG_CHOICES)
         {
            numberOfGamesLost++;
            statusLabel.Text = string.Format("You're hung!   Won: {0} Lost: {1}",
               numberOfGamesWon, numberOfGamesLost);
            disableLetterButtons();
            displaySecretWord();
            giveUpToolStripMenuItem.Visible = false;
            giveMeAHintToolStripMenuItem.Visible = false;
         }
      }

      // Sets up the start of a new game
      private void startNewGameToolStripMenuItem_Click(object sender, EventArgs e)
      {
         // Reset counter
         lettersWrongCounter = 0;

         // Make Give Up menu button visible and enable
         giveUpToolStripMenuItem.Visible = true;
         giveUpToolStripMenuItem.Enabled = true;

         // Hide give me a hint button and enable
         giveMeAHintToolStripMenuItem.Visible = false;
         giveMeAHintToolStripMenuItem.Enabled = true;

         // Hide next instruction button
         nextInstructionButton.Visible = false;

         // Hide URL source link
         textSourceLink.Visible = false;

         // Enable all letter buttons and turn then green
         enableLetterButtons();
         turnLetterButtonsGreen();

         // Select a new SercetWord
         clearSecretWordDisplay();
         wordFile.SecretWord = wordFile.selectRandomSecretWord();

         /***** Test code *****/
         // Set SecretWord to know value for testing
         // wordFile.SecretWord = "happy";

         // Set variables to process game
         lettersRemainingCounter = wordFile.SecretWord.Length;
         statusLabel.Text = string.Format("Your new word has {0} letters", wordFile.SecretWord.Length);

         // Fill word label array with all blanks
         makeBlankDisplayVisible();

         // Reset hanging man image
         drawingPictureBox.Image = Properties.Resources.Man0;
      }

      // Sets up the View Instruction images for clicking through all instructions
      private void viewInstrutionsToolStripMenuItem_Click(object sender, EventArgs e)
      {
         // Display first instruction image
         drawingPictureBox.Image = instructionImages[0];

         // Make Give Up menu button visible and disabled
         giveUpToolStripMenuItem.Visible = true;
         giveUpToolStripMenuItem.Enabled = false;

         // Hide Give me a hint button
         giveMeAHintToolStripMenuItem.Visible = false;

         // Make Next Instruction button visible
         nextInstructionButton.Visible = true;

         // Hide URL source link
         textSourceLink.Visible = false;

         // Disable all letter buttons and turn them green
         disableLetterButtons();
         turnLetterButtonsGreen();

         // Display message in status box
         statusLabel.Text = "Press Next Instruction";

         // Reset count to zero
         instructionImageCounter = 0;

         // Set and display "hangman" as SecretWord
         clearSecretWordDisplay();
         wordFile.SecretWord = "hangman";
         makeBlankDisplayVisible();
         displaySecretWord();
      }

      // Cycles through the instruction images
      private void nextInstructionButton_Click(object sender, EventArgs e)
      {
         // Increment counter
         instructionImageCounter++;

         // Check if image has reach the end. If so, reset counter.
         if (instructionImageCounter == NUMBER_OF_INSTRUCTION_IMAGES) instructionImageCounter = 0;

         // Check if image is for Give me a hint instruction image
         if (instructionImageCounter == GIVE_ME_A_HINT_IMAGE)
         {
            // Make Give me a hint button visible and diabled
            giveMeAHintToolStripMenuItem.Visible = true;
            giveMeAHintToolStripMenuItem.Enabled = false;
         }
         // Check if image is for URL text source instruction
         else if (instructionImageCounter == TEXT_SOURCE_IMAGE)
         {
            textSourceLink.Visible = true;
         }
         else
         {
            // Hide Give mive me a hint button and URL source link
            giveMeAHintToolStripMenuItem.Visible = false;
            textSourceLink.Visible = false;
         }

         // Display instruction image
         drawingPictureBox.Image = instructionImages[instructionImageCounter];
      }

      // Actions performed when the Give Up menu button is clicked
      private void giveUpToolStripMenuItem_Click(object sender, EventArgs e)
      {
         // Increment counter
         numberOfGamesLost++;

         // Display values
         statusLabel.Text = string.Format("You gave up!   Won: {0} Lost: {1}",
               numberOfGamesWon, numberOfGamesLost);
         drawingPictureBox.Image = Properties.Resources.DeadMan;
         displaySecretWord();

         // Disable buttons
         disableLetterButtons();
         giveUpToolStripMenuItem.Visible = false;
         giveMeAHintToolStripMenuItem.Visible = false;
      }

      // Reveal the first correct letter that has not been selected
      private void giveMeAHintToolStripMenuItem_Click(object sender, EventArgs e)
      {
         // Iterate through the Secret Word
         for (int i = 0; i < wordFile.SecretWord.Length; i++)
         {
            // Generate a unique character code: a = 0 through z = 25
            int charCodeFor_a = 97;
            int characterCode = wordFile.SecretWord[i] - charCodeFor_a;

            // Check if button is still enabled (ie it has not been clicked)
            if (charButtons[characterCode].Enabled)
            {
               // If not, click the letter button and break from the iteration
               buttonClicked(charButtons[characterCode]);
               break;
            }
         }

         // Make menu button invisible
         giveMeAHintToolStripMenuItem.Visible = false;
      }

      // Actives link which connects to web text source page
      private void textSourceLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
      {
         System.Diagnostics.Process.Start(e.Link.LinkData as string);
      }

      /***** The following are helper methods *****/

      // Disable all letter buttons
      private void disableLetterButtons()
      {
         for (int i = 0; i < NUMBER_OF_BUTTONS; i++)
         {
            charButtons[i].Enabled = false;
         }
      }

      // Enable all letter buttons
      private void enableLetterButtons()
      {
         for (int i = 0; i < NUMBER_OF_BUTTONS; i++)
         {
            charButtons[i].Enabled = true;
         }
      }

      // Turn all letter buttons green
      private void turnLetterButtonsGreen()
      {
         for (int i = 0; i < NUMBER_OF_BUTTONS; i++)
         {
            charButtons[i].BackColor = GREEN;
         }
      }

      // Clear SecretWord display
      private void clearSecretWordDisplay()
      {
         for (int i = 0; i < MAXIMUM_WORD_SIZE; i++)
         {
            wordLabels[i].Text = "";
            wordLabels[i].Visible = false;
         }
      }

      // Make display visible for new SecretWord
      private void makeBlankDisplayVisible()
      {
         for (int i = 0; i < wordFile.SecretWord.Length; i++)
         {
            wordLabels[i].Visible = true;
         }
      }

      // Display the SecretWord
      private void displaySecretWord()
      {
         for (int i = 0; i < wordFile.SecretWord.Length; i++)
         {
            wordLabels[i].Text = wordFile.SecretWord.Substring(i, 1);
         }
      }
   }
}