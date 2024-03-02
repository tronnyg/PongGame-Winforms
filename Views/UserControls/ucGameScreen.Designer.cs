namespace PongGame.UserControls
{
    partial class ucGameScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.picPlayer2 = new System.Windows.Forms.PictureBox();
            this.picPlayer1 = new System.Windows.Forms.PictureBox();
            this.tmrTick = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // picPlayer2
            // 
            this.picPlayer2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picPlayer2.Location = new System.Drawing.Point(1060, 334);
            this.picPlayer2.Name = "picPlayer2";
            this.picPlayer2.Size = new System.Drawing.Size(41, 115);
            this.picPlayer2.TabIndex = 2;
            this.picPlayer2.TabStop = false;
            // 
            // picPlayer1
            // 
            this.picPlayer1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picPlayer1.Location = new System.Drawing.Point(23, 334);
            this.picPlayer1.Name = "picPlayer1";
            this.picPlayer1.Size = new System.Drawing.Size(41, 115);
            this.picPlayer1.TabIndex = 5;
            this.picPlayer1.TabStop = false;
            // 
            // tmrTick
            // 
            this.tmrTick.Tick += new System.EventHandler(this.tmrTick_Tick);
            // 
            // ucGameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.picPlayer1);
            this.Controls.Add(this.picPlayer2);
            this.Name = "ucGameScreen";
            this.Size = new System.Drawing.Size(1123, 752);
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picPlayer2;
        private System.Windows.Forms.PictureBox picPlayer1;
        private System.Windows.Forms.Timer tmrTick;
    }
}
