namespace PongGame
{
    partial class frmMain
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
            this.ucGameScreen1 = new PongGame.UserControls.ucGameScreen();
            this.SuspendLayout();
            // 
            // ucGameScreen1
            // 
            this.ucGameScreen1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ucGameScreen1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGameScreen1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucGameScreen1.Location = new System.Drawing.Point(40, 40);
            this.ucGameScreen1.Name = "ucGameScreen1";
            this.ucGameScreen1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.ucGameScreen1.Size = new System.Drawing.Size(1125, 754);
            this.ucGameScreen1.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1207, 845);
            this.Controls.Add(this.ucGameScreen1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMain";
            this.Text = "git ";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.ucGameScreen ucGameScreen1;
    }
}

