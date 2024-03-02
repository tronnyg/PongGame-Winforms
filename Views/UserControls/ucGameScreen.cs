using PongGame.src.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PongGame.UserControls
{
    public partial class ucGameScreen : UserControl
    {
        //===== VARIABLES =====//
        pongBall newBall;

        //===== CONTROL INIT =====//
        public ucGameScreen()
        {
            InitializeComponent();

            // Create new ball and add to control
            newBall = new pongBall(new Size(35, 35), Color.White, this.Width, this.Height);
            this.Controls.Add(this.newBall);

            // Enable timer
            this.DoubleBuffered = true;
            tmrTick.Interval = 17;
            tmrTick.Enabled = true;
        }

        //===== TIMER TICK =====//
        private void tmrTick_Tick(object sender, EventArgs e)
        {
            newBall.moveBall(); // Move ball 
            newBall.checkBoundries(); // Check if ball hit any borders
        }

    }
}
// =========================== END OF FILE =========================== //
