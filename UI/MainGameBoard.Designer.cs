using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace UI
{
    public partial class MainGameBoard
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
            this.buttonGameGuessFirst = new System.Windows.Forms.Button();
            this.buttonGameGuessSecond = new System.Windows.Forms.Button();
            this.buttonGameGuessThird = new System.Windows.Forms.Button();
            this.buttonGameGuessFourth = new System.Windows.Forms.Button();
            this.buttonGuess1 = new System.Windows.Forms.Button();
            this.buttonGuess2 = new System.Windows.Forms.Button();
            this.buttonGuess3 = new System.Windows.Forms.Button();
            this.buttonGuess4 = new System.Windows.Forms.Button();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonHitOrMiss1 = new System.Windows.Forms.Button();
            this.buttonHitOrMiss3 = new System.Windows.Forms.Button();
            this.buttonHitOrMiss2 = new System.Windows.Forms.Button();
            this.buttonHitOrMiss4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonGameGuessFirst
            // 
            this.buttonGameGuessFirst.BackColor = System.Drawing.Color.Black;
            this.buttonGameGuessFirst.Enabled = false;
            this.buttonGameGuessFirst.Location = new System.Drawing.Point(16, 15);
            this.buttonGameGuessFirst.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGameGuessFirst.Name = "buttonGameGuessFirst";
            this.buttonGameGuessFirst.Size = new System.Drawing.Size(67, 62);
            this.buttonGameGuessFirst.TabIndex = 0;
            this.buttonGameGuessFirst.UseVisualStyleBackColor = false;
            // 
            // buttonGameGuessSecond
            // 
            this.buttonGameGuessSecond.BackColor = System.Drawing.Color.Black;
            this.buttonGameGuessSecond.Enabled = false;
            this.buttonGameGuessSecond.Location = new System.Drawing.Point(91, 15);
            this.buttonGameGuessSecond.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGameGuessSecond.Name = "buttonGameGuessSecond";
            this.buttonGameGuessSecond.Size = new System.Drawing.Size(67, 62);
            this.buttonGameGuessSecond.TabIndex = 1;
            this.buttonGameGuessSecond.UseVisualStyleBackColor = false;
            // 
            // buttonGameGuessThird
            // 
            this.buttonGameGuessThird.BackColor = System.Drawing.Color.Black;
            this.buttonGameGuessThird.Enabled = false;
            this.buttonGameGuessThird.Location = new System.Drawing.Point(165, 15);
            this.buttonGameGuessThird.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGameGuessThird.Name = "buttonGameGuessThird";
            this.buttonGameGuessThird.Size = new System.Drawing.Size(67, 62);
            this.buttonGameGuessThird.TabIndex = 2;
            this.buttonGameGuessThird.UseVisualStyleBackColor = false;
            // 
            // buttonGameGuessFourth
            // 
            this.buttonGameGuessFourth.BackColor = System.Drawing.Color.Black;
            this.buttonGameGuessFourth.Enabled = false;
            this.buttonGameGuessFourth.Location = new System.Drawing.Point(240, 15);
            this.buttonGameGuessFourth.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGameGuessFourth.Name = "buttonGameGuessFourth";
            this.buttonGameGuessFourth.Size = new System.Drawing.Size(67, 62);
            this.buttonGameGuessFourth.TabIndex = 3;
            this.buttonGameGuessFourth.UseVisualStyleBackColor = false;
            // 
            // buttonGuess1
            // 
            this.buttonGuess1.Location = new System.Drawing.Point(16, 100);
            this.buttonGuess1.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGuess1.Name = "buttonGuess1";
            this.buttonGuess1.Size = new System.Drawing.Size(67, 62);
            this.buttonGuess1.TabIndex = 0;
            this.buttonGuess1.Click += new System.EventHandler(this.buttonGuess_Click);
            // 
            // buttonGuess2
            // 
            this.buttonGuess2.Location = new System.Drawing.Point(91, 100);
            this.buttonGuess2.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGuess2.Name = "buttonGuess2";
            this.buttonGuess2.Size = new System.Drawing.Size(67, 62);
            this.buttonGuess2.TabIndex = 1;
            this.buttonGuess2.Click += new System.EventHandler(this.buttonGuess_Click);
            // 
            // buttonGuess3
            // 
            this.buttonGuess3.Location = new System.Drawing.Point(165, 100);
            this.buttonGuess3.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGuess3.Name = "buttonGuess3";
            this.buttonGuess3.Size = new System.Drawing.Size(67, 62);
            this.buttonGuess3.TabIndex = 2;
            this.buttonGuess3.Click += new System.EventHandler(this.buttonGuess_Click);
            // 
            // buttonGuess4
            // 
            this.buttonGuess4.Location = new System.Drawing.Point(240, 100);
            this.buttonGuess4.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGuess4.Name = "buttonGuess4";
            this.buttonGuess4.Size = new System.Drawing.Size(67, 62);
            this.buttonGuess4.TabIndex = 3;
            this.buttonGuess4.Click += new System.EventHandler(this.buttonGuess_Click);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Enabled = false;
            this.buttonSubmit.Location = new System.Drawing.Point(315, 114);
            this.buttonSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(67, 28);
            this.buttonSubmit.TabIndex = 4;
            this.buttonSubmit.Text = "-->>";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // buttonHitOrMiss1
            // 
            this.buttonHitOrMiss1.Enabled = false;
            this.buttonHitOrMiss1.Location = new System.Drawing.Point(389, 105);
            this.buttonHitOrMiss1.Margin = new System.Windows.Forms.Padding(4);
            this.buttonHitOrMiss1.Name = "buttonHitOrMiss1";
            this.buttonHitOrMiss1.Size = new System.Drawing.Size(27, 25);
            this.buttonHitOrMiss1.TabIndex = 5;
            this.buttonHitOrMiss1.UseVisualStyleBackColor = true;
            // 
            // buttonHitOrMiss3
            // 
            this.buttonHitOrMiss3.Enabled = false;
            this.buttonHitOrMiss3.Location = new System.Drawing.Point(389, 137);
            this.buttonHitOrMiss3.Margin = new System.Windows.Forms.Padding(4);
            this.buttonHitOrMiss3.Name = "buttonHitOrMiss3";
            this.buttonHitOrMiss3.Size = new System.Drawing.Size(27, 25);
            this.buttonHitOrMiss3.TabIndex = 6;
            this.buttonHitOrMiss3.UseVisualStyleBackColor = true;
            // 
            // buttonHitOrMiss2
            // 
            this.buttonHitOrMiss2.Enabled = false;
            this.buttonHitOrMiss2.Location = new System.Drawing.Point(424, 105);
            this.buttonHitOrMiss2.Margin = new System.Windows.Forms.Padding(4);
            this.buttonHitOrMiss2.Name = "buttonHitOrMiss2";
            this.buttonHitOrMiss2.Size = new System.Drawing.Size(27, 25);
            this.buttonHitOrMiss2.TabIndex = 7;
            this.buttonHitOrMiss2.UseVisualStyleBackColor = true;
            // 
            // buttonHitOrMiss4
            // 
            this.buttonHitOrMiss4.Enabled = false;
            this.buttonHitOrMiss4.Location = new System.Drawing.Point(424, 137);
            this.buttonHitOrMiss4.Margin = new System.Windows.Forms.Padding(4);
            this.buttonHitOrMiss4.Name = "buttonHitOrMiss4";
            this.buttonHitOrMiss4.Size = new System.Drawing.Size(27, 25);
            this.buttonHitOrMiss4.TabIndex = 8;
            this.buttonHitOrMiss4.UseVisualStyleBackColor = true;
            // 
            // MainGameBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(459, 373);
            this.Controls.Add(this.buttonHitOrMiss4);
            this.Controls.Add(this.buttonHitOrMiss2);
            this.Controls.Add(this.buttonHitOrMiss3);
            this.Controls.Add(this.buttonHitOrMiss1);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.buttonGuess1);
            this.Controls.Add(this.buttonGuess2);
            this.Controls.Add(this.buttonGuess3);
            this.Controls.Add(this.buttonGuess4);
            this.Controls.Add(this.buttonGameGuessFourth);
            this.Controls.Add(this.buttonGameGuessThird);
            this.Controls.Add(this.buttonGameGuessSecond);
            this.Controls.Add(this.buttonGameGuessFirst);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainGameBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bool Pgia";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGameGuessFirst;
        private System.Windows.Forms.Button buttonGameGuessSecond;
        private System.Windows.Forms.Button buttonGameGuessThird;
        private System.Windows.Forms.Button buttonGameGuessFourth;
        private Button buttonGuess1;
        private Button buttonGuess2;
        private Button buttonGuess3;
        private Button buttonGuess4;
        private Button buttonSubmit;
        private Button buttonHitOrMiss1;
        private Button buttonHitOrMiss3;
        private Button buttonHitOrMiss2;
        private Button buttonHitOrMiss4;
    }
}