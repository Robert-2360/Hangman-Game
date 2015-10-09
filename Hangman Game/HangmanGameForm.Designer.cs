namespace Hangman_Game
{
   partial class HangmanGameForm
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.SuspendLayout();
         // 
         // HangmanGameForm
         // 
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
         this.ClientSize = new System.Drawing.Size(982, 554);
         this.Font = new System.Drawing.Font("Segoe UI", 20.03478F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.MaximizeBox = false;
         this.Name = "HangmanGameForm";
         this.Text = "Hangman Game";
         this.ResumeLayout(false);

      }

      #endregion
   }
}

