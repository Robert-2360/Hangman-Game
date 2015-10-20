using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman_Game
{
   public partial class HangmanGameForm : Form
   {
      private WordFile wordFile;

      private int lettersRemainingCounter;

      private Label[] wordLabels;
      private int maxWordSize = 9;

      private Button[] charButtons;

      public HangmanGameForm()
      {
         InitializeComponent();

         wordFile = new WordFile();

         // Initialize label array for SecretWord letters display
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
         charButtons = new Button[26];
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
      }

      // The following 26 methods are for each letter choice button
      private void aCharButton_Click(object sender, EventArgs e)
      {
         buttonClicked(aCharButton);
      }

      private void bCharButton_Click(object sender, EventArgs e)
      {
         buttonClicked(bCharButton);
      }

      private void cCharButton_Click(object sender, EventArgs e)
      {
         buttonClicked(cCharButton);
      }

      private void dCharButton_Click(object sender, EventArgs e)
      {
         buttonClicked(dCharButton);
      }

      private void eCharButton_Click(object sender, EventArgs e)
      {
         buttonClicked(eCharButton);
      }

      private void fCharButton_Click(object sender, EventArgs e)
      {
         buttonClicked(fCharButton);
      }

      private void gCharButton_Click(object sender, EventArgs e)
      {
         buttonClicked(gCharButton);
      }

      private void hCharButton_Click(object sender, EventArgs e)
      {
         buttonClicked(hCharButton);
      }

      private void iCharButton_Click(object sender, EventArgs e)
      {
         buttonClicked(iCharButton);
      }

      private void jCharButton_Click(object sender, EventArgs e)
      {
         buttonClicked(jCharButton);
      }

      private void kCharButton_Click(object sender, EventArgs e)
      {
         buttonClicked(kCharButton);
      }

      private void lCharButton_Click(object sender, EventArgs e)
      {
         buttonClicked(lCharButton);
      }

      private void mCharButton_Click(object sender, EventArgs e)
      {
         buttonClicked(mCharButton);
      }

      private void nCharButton_Click(object sender, EventArgs e)
      {
         buttonClicked(nCharButton);
      }

      private void oCharButton_Click(object sender, EventArgs e)
      {
         buttonClicked(oCharButton);
      }

      private void pCharButton_Click(object sender, EventArgs e)
      {
         buttonClicked(pCharButton);
      }

      private void qCharButton_Click(object sender, EventArgs e)
      {
         buttonClicked(qCharButton);
      }

      private void rCharButton_Click(object sender, EventArgs e)
      {
         buttonClicked(rCharButton);
      }

      private void sCharButton_Click(object sender, EventArgs e)
      {
         buttonClicked(sCharButton);
      }

      private void tCharButton_Click(object sender, EventArgs e)
      {
         buttonClicked(tCharButton);
      }

      private void uCharButton_Click(object sender, EventArgs e)
      {
         buttonClicked(uCharButton);
      }

      private void vCharButton_Click(object sender, EventArgs e)
      {
         buttonClicked(vCharButton);
      }

      private void wCharButton_Click(object sender, EventArgs e)
      {
         buttonClicked(wCharButton);
      }

      private void xCharButton_Click(object sender, EventArgs e)
      {
         buttonClicked(xCharButton);
      }

      private void yCharButton_Click(object sender, EventArgs e)
      {
         buttonClicked(yCharButton);
      }

      private void zCharButton_Click(object sender, EventArgs e)
      {
         buttonClicked(zCharButton);
      }

      // Actions performed when a letter button is clicked
      private void buttonClicked(Button b)
      {
         // Disable button
         b.Enabled = false;
         b.BackColor = Color.FromArgb(255, 232, 235);

         // If present in SecretWord, make that letter visible
         for (int i = 0; i < wordFile.SecretWord.Length; i++)
         {
            if (wordFile.SecretWord[i] == Convert.ToChar(b.Text))
            {
               wordLabels[i].Text = b.Text;
               lettersRemainingCounter--;
            }
         }

         // Check if game is over
         if (lettersRemainingCounter == 0)
         {
            statusLabel.Text = "You win";
            giveMeAHintToolStripMenuItem.Visible = false;
            giveUpToolStripMenuItem.Visible = false;
         }
      }

      // Actions performed when the Start New Game menu item is clicked
      private void startNewGameToolStripMenuItem_Click(object sender, EventArgs e)
      {
         // Enable letter buttons
         for (int i = 0; i < 26; i++)
         {
            charButtons[i].Enabled = true;
            charButtons[i].BackColor = Color.FromArgb(202, 234, 189);
         }

         // Let game playing menu items be visible
         giveMeAHintToolStripMenuItem.Visible = true;
         giveUpToolStripMenuItem.Visible = true;

         // Select a new SercetWord
         wordFile.setSecretWord();
         lettersRemainingCounter = wordFile.SecretWord.Length;
         statusLabel.Text = string.Format("Your new word has {0} letters", wordFile.SecretWord.Length);

         // Clear SecretWord display
         for (int i = 0; i < maxWordSize; i++)
         {
            wordLabels[i].Text = "";
            wordLabels[i].Visible = false;
         }

         // Make display visible for new SecretWord
         for (int i = 0; i < wordFile.SecretWord.Length; i++)
         {
            wordLabels[i].Visible = true;
         }
      }

      // Actions performed when the View Instructions menu item is clicked
      private void viewInstrutionsToolStripMenuItem_Click(object sender, EventArgs e)
      {

      }
   }
}
