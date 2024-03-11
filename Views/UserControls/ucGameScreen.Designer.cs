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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucGameScreen));
            this.tmrTick = new System.Windows.Forms.Timer(this.components);
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.lblCenter = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrTick
            // 
            this.tmrTick.Tick += new System.EventHandler(this.tmrTick_Tick);
            // 
            // lblPlayer1
            // 
            resources.ApplyResources(this.lblPlayer1, "lblPlayer1");
            this.lblPlayer1.ForeColor = System.Drawing.Color.White;
            this.lblPlayer1.Name = "lblPlayer1";
            // 
            // lblPlayer2
            // 
            resources.ApplyResources(this.lblPlayer2, "lblPlayer2");
            this.lblPlayer2.ForeColor = System.Drawing.Color.White;
            this.lblPlayer2.Name = "lblPlayer2";
            // 
            // lblCenter
            // 
            resources.ApplyResources(this.lblCenter, "lblCenter");
            this.lblCenter.ForeColor = System.Drawing.Color.White;
            this.lblCenter.Name = "lblCenter";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.Controls.Add(this.lblPlayer1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPlayer2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCenter, 1, 0);
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // ucGameScreen
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Name = "ucGameScreen";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ucGameScreen_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ucGameScreen_KeyUp);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer tmrTick;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.Label lblCenter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
