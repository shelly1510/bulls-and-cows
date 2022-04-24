namespace UI
{
    public partial class ColorPallet
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
            this.buttonPink = new System.Windows.Forms.Button();
            this.buttonRed = new System.Windows.Forms.Button();
            this.buttonGreen = new System.Windows.Forms.Button();
            this.buttonCyan = new System.Windows.Forms.Button();
            this.buttonBlue = new System.Windows.Forms.Button();
            this.buttonYellow = new System.Windows.Forms.Button();
            this.buttonBrown = new System.Windows.Forms.Button();
            this.buttonWhite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPink
            // 
            this.buttonPink.BackColor = System.Drawing.Color.MediumVioletRed;
            this.buttonPink.ForeColor = System.Drawing.Color.Transparent;
            this.buttonPink.Location = new System.Drawing.Point(16, 15);
            this.buttonPink.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonPink.Name = "buttonPink";
            this.buttonPink.Size = new System.Drawing.Size(88, 78);
            this.buttonPink.TabIndex = 0;
            this.buttonPink.UseVisualStyleBackColor = false;
            this.buttonPink.Click += new System.EventHandler(this.pinkButton_Click);
            // 
            // buttonRed
            // 
            this.buttonRed.BackColor = System.Drawing.Color.Red;
            this.buttonRed.ForeColor = System.Drawing.Color.Transparent;
            this.buttonRed.Location = new System.Drawing.Point(112, 15);
            this.buttonRed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonRed.Name = "buttonRed";
            this.buttonRed.Size = new System.Drawing.Size(88, 78);
            this.buttonRed.TabIndex = 1;
            this.buttonRed.UseVisualStyleBackColor = false;
            this.buttonRed.Click += new System.EventHandler(this.redButton_Click);
            // 
            // buttonGreen
            // 
            this.buttonGreen.BackColor = System.Drawing.Color.LawnGreen;
            this.buttonGreen.ForeColor = System.Drawing.Color.Transparent;
            this.buttonGreen.Location = new System.Drawing.Point(208, 15);
            this.buttonGreen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonGreen.Name = "buttonGreen";
            this.buttonGreen.Size = new System.Drawing.Size(88, 78);
            this.buttonGreen.TabIndex = 2;
            this.buttonGreen.UseVisualStyleBackColor = false;
            this.buttonGreen.Click += new System.EventHandler(this.greenButton_Click);
            // 
            // buttonCyan
            // 
            this.buttonCyan.BackColor = System.Drawing.Color.Cyan;
            this.buttonCyan.ForeColor = System.Drawing.Color.Transparent;
            this.buttonCyan.Location = new System.Drawing.Point(304, 15);
            this.buttonCyan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCyan.Name = "buttonCyan";
            this.buttonCyan.Size = new System.Drawing.Size(88, 78);
            this.buttonCyan.TabIndex = 3;
            this.buttonCyan.UseVisualStyleBackColor = false;
            this.buttonCyan.Click += new System.EventHandler(this.cyanButton_Click);
            // 
            // buttonBlue
            // 
            this.buttonBlue.BackColor = System.Drawing.Color.Blue;
            this.buttonBlue.ForeColor = System.Drawing.Color.Transparent;
            this.buttonBlue.Location = new System.Drawing.Point(16, 100);
            this.buttonBlue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonBlue.Name = "buttonBlue";
            this.buttonBlue.Size = new System.Drawing.Size(88, 78);
            this.buttonBlue.TabIndex = 4;
            this.buttonBlue.UseVisualStyleBackColor = false;
            this.buttonBlue.Click += new System.EventHandler(this.blueButton_Click);
            // 
            // buttonYellow
            // 
            this.buttonYellow.BackColor = System.Drawing.Color.Yellow;
            this.buttonYellow.ForeColor = System.Drawing.Color.Transparent;
            this.buttonYellow.Location = new System.Drawing.Point(112, 100);
            this.buttonYellow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonYellow.Name = "buttonYellow";
            this.buttonYellow.Size = new System.Drawing.Size(88, 78);
            this.buttonYellow.TabIndex = 5;
            this.buttonYellow.UseVisualStyleBackColor = false;
            this.buttonYellow.Click += new System.EventHandler(this.yellowButton_Click);
            // 
            // buttonBrown
            // 
            this.buttonBrown.BackColor = System.Drawing.Color.SaddleBrown;
            this.buttonBrown.ForeColor = System.Drawing.Color.Transparent;
            this.buttonBrown.Location = new System.Drawing.Point(208, 100);
            this.buttonBrown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonBrown.Name = "buttonBrown";
            this.buttonBrown.Size = new System.Drawing.Size(88, 78);
            this.buttonBrown.TabIndex = 6;
            this.buttonBrown.UseVisualStyleBackColor = false;
            this.buttonBrown.Click += new System.EventHandler(this.brownButton_Click);
            // 
            // buttonWhite
            // 
            this.buttonWhite.BackColor = System.Drawing.Color.White;
            this.buttonWhite.ForeColor = System.Drawing.Color.Transparent;
            this.buttonWhite.Location = new System.Drawing.Point(304, 100);
            this.buttonWhite.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonWhite.Name = "buttonWhite";
            this.buttonWhite.Size = new System.Drawing.Size(88, 78);
            this.buttonWhite.TabIndex = 7;
            this.buttonWhite.UseVisualStyleBackColor = false;
            this.buttonWhite.Click += new System.EventHandler(this.whiteButton_Click);
            // 
            // ColorPallet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(401, 186);
            this.Controls.Add(this.buttonWhite);
            this.Controls.Add(this.buttonBrown);
            this.Controls.Add(this.buttonYellow);
            this.Controls.Add(this.buttonBlue);
            this.Controls.Add(this.buttonCyan);
            this.Controls.Add(this.buttonGreen);
            this.Controls.Add(this.buttonRed);
            this.Controls.Add(this.buttonPink);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ColorPallet";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pick A Color:";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPink;
        private System.Windows.Forms.Button buttonRed;
        private System.Windows.Forms.Button buttonGreen;
        private System.Windows.Forms.Button buttonCyan;
        private System.Windows.Forms.Button buttonBlue;
        private System.Windows.Forms.Button buttonYellow;
        private System.Windows.Forms.Button buttonBrown;
        private System.Windows.Forms.Button buttonWhite;
    }
}