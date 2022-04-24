namespace UI
{
    public partial class TurnsForm
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
            this.buttonNumberOfTurns = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonNumberOfTurns
            // 
            this.buttonNumberOfTurns.Location = new System.Drawing.Point(16, 26);
            this.buttonNumberOfTurns.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonNumberOfTurns.Name = "buttonNumberOfTurns";
            this.buttonNumberOfTurns.Size = new System.Drawing.Size(412, 39);
            this.buttonNumberOfTurns.TabIndex = 0;
            this.buttonNumberOfTurns.Text = "Number of Chances: 4";
            this.buttonNumberOfTurns.UseVisualStyleBackColor = true;
            this.buttonNumberOfTurns.Click += new System.EventHandler(this.buttonNumberOfTurns_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(297, 108);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(129, 42);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // TurnsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 167);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonNumberOfTurns);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TurnsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bool Pgia";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNumberOfTurns;
        private System.Windows.Forms.Button buttonStart;
    }
}