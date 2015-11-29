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

      // Declare or initialize class variables
      private WordFile wordFile;

      private Label[] wordLabels;
      private Button[] charButtons;
      private Image[] hangingManImages;
      private Image[] instructionImages;

      private int lettersRemainingCounter;
      private int lettersWrongCounter;
      private int instructionImageCounter;
      private int maxWordSize = 9;
      private int numberOfButtons = 26;
      private int numberOfManImages = 8;
      private int maximumWrongChoices = 7;
      private int numberOfInstructionImages = 3;

      private Color red = Color.FromArgb(255, 232, 235);
      private Color green = Color.FromArgb(202, 234, 189);

      // Actions preformed when game form is first loaded
      private void HangmanGameForm_Load(object sender, EventArgs e)
      {
         wordFile = new WordFile();
         nextInstructionButton.Visible = false;

         // Initialize label array for SecretWord display
         wordLabels = new Label[maxWordSize];
         wordLabels[0] = wordChar0;
         wordLabels[1] = wordChar1;
         wordLabels[2] = wordChar2;
         wordLabels[3] = wordChar3;
         wordLabels[4] = wordChar4;
         wordLabels[5] = wordChar5;
         wordLabels[6] = wordChar6;
         wordLabels[7] = wordChar7;
         wordLabels[8] = wordChar8;

         // Initialize button array for letter choices box
         charButtons = new Button[numberOfButtons];
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
         hangingManImages = new Image[numberOfManImages];
         hangingManImages[0] = Properties.Resources.Man0;
         hangingManImages[1] = Properties.Resources.Man1;
         hangingManImages[2] = Properties.Resources.Man2;
         hangingManImages[3] = Properties.Resources.Man3;
         hangingManImages[4] = Properties.Resources.Man4;
         hangingManImages[5] = Properties.Resources.Man5;
         hangingManImages[6] = Properties.Resources.Man6;
         hangingManImages[7] = Properties.Resources.DeadMan;

         // Initialize image array for instruction images
         instructionImages = new Image[numberOfInstructionImages];
         instructionImages[0] = Properties.Resources.Instructions0;
         instructionImages[1] = Properties.Resources.Instructions1;
         instructionImages[2] = Properties.Resources.Instructions2;

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

         // Disable button
         b.Enabled = false;
         b.BackColor = red;

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

               // Update counter and flip letterFound bool
               lettersRemainingCounter--;
               letterFound = true;
            }
         }

         // If letter selected was wrong increment counter and display next hangman image
         if (!letterFound)
         {
            lettersWrongCounter++;
            drawingPictureBox.Image = hangingManImages[lettersWrongCounter];
         }

         // Update status label
         statusLabel.Text = string.Format("Remaining: {0} Letters wrong: {1}",
            lettersRemainingCounter, lettersWrongCounter);

         // Determine if game has been won
         if (lettersRemainingCounter == 0)
         {
            statusLabel.Text = "You win";
            drawingPictureBox.Image = Properties.Resources.AliveMan;
            disableLetterButtons();
         }

         // Determine if game has been lost
         if (lettersWrongCounter == maximumWrongChoices)
         {
            statusLabel.Text = "You have hung your man";
            disableLetterButtons();
            displaySecretWord();
         }
      }

      // Actions performed when the Start New Game menu item is clicked
      private void startNewGameToolStripMenuItem_Click(object sender, EventArgs e)
      {
         // Reset counter
         lettersWrongCounter = 0;

         // Hide next instruction button
         nextInstructionButton.Visible = false;

         // Enable letter buttons
         enableLetterButtons();

         // Select a new SercetWord
         clearSecretWordDisplay();
         wordFile.selectRandomSecretWord();
         lettersRemainingCounter = wordFile.SecretWord.Length;
         statusLabel.Text = string.Format("Your new word has {0} letters", wordFile.SecretWord.Length);
         makeBlankDisplayVisible();
         
         // Reset hanging man image
         drawingPictureBox.Image = Properties.Resources.Man0;
      }

      // Actions performed when the View Instructions menu item is clicked
      private void viewInstrutionsToolStripMenuItem_Click(object sender, EventArgs e)
      {
         drawingPictureBox.Image = instructionImages[0];
         nextInstructionButton.Visible = true;
         instructionImageCounter = 0;
         disableLetterButtons();

         // Set "hangman" as a visible SecretWord
         clearSecretWordDisplay();
         wordFile.SecretWord = "hangman";
         makeBlankDisplayVisible();
         displaySecretWord();
      }

      // Actions performed when the Next Instruction button is clicked
      private void nextInstructionButton_Click(object sender, EventArgs e)
      {
         // Cycles through the instruction images
         instructionImageCounter++;
         if (instructionImageCounter == numberOfInstructionImages) instructionImageCounter = 0;
         drawingPictureBox.Image = instructionImages[instructionImageCounter];
      }


      /***** The following are helper methods *****/

      // Disable all letter buttons
      private void disableLetterButtons()
      {
         for (int i = 0; i < numberOfButtons; i++)
         {
            charButtons[i].Enabled = false;
         }
      }

      // Enable all letter buttons
      private void enableLetterButtons()
      {
         for (int i = 0; i < numberOfButtons; i++)
         {
            charButtons[i].Enabled = true;
            charButtons[i].BackColor = green;
         }
      }

      // Clear SecretWord display
      private void clearSecretWordDisplay()
      {
         for (int i = 0; i < maxWordSize; i++)
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