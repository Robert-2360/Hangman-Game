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
      public HangmanGameForm()
      {
         InitializeComponent();
      }

      private void buttonClicked(Button b)
      {
         b.Enabled = false;
         b.BackColor = Color.FromArgb(255, 232, 235);
      }

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
   }
}
