using PongGame.src.Events;
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
        PongBall newBall;
        Player player1;
        Player player2;
        KeyboardEvents keyboardEvents = new KeyboardEvents();

        //===== CONTROL INIT =====//
        public ucGameScreen()
        {
            InitializeComponent();

            // Create ball and players and add to control
            newBall = new PongBall(new Size(35, 35), Color.White, this.Width, this.Height);
            player1 = new Player(new Size(41, 115),Color.WhiteSmoke, new Point(50, 334),10,1,"Player 1", this.Height, this.Width);
            player2 = new Player(new Size(41, 115),Color.WhiteSmoke, new Point(1023, 334),10,1, "Player 2", this.Height, this.Width);
            this.Controls.Add(this.newBall);
            this.Controls.Add(player1);
            this.Controls.Add(player2);

            // Enable timer
            this.DoubleBuffered = true; 
            tmrTick.Interval = 15;
            tmrTick.Enabled = true;
        }

        //===== TIMER TICK =====//
        private void tmrTick_Tick(object sender, EventArgs e)
        {
            // Move ball 
            newBall.moveBall();
            // Check if ball hit any borders
            newBall.checkBoundries(); 
            // Check if ball hits players
            newBall.checkPlayerHit(player1); 
            newBall.checkPlayerHit(player2);
            keyboardEvents.playerOutput(player1,player2);

        }

        //===== KEY DOWN EVENTS =====//
        private void ucGameScreen_KeyDown(object sender, KeyEventArgs e)
        {
            keyboardEvents.keyInput(e, "down");
        }

        private void ucGameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            keyboardEvents.keyInput(e, "up");
        }
    }
}
// =========================== END OF FILE =========================== //
