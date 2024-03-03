using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PongGame.src.Objects
{
    internal class Player: PictureBox
    {
        //===== VARIABLES =====//
        string playerName;
        int playerScore = 0;
        int playerWins = 0;
        int playerBounceLvl;
        int playerSpeed = 0;

        //===== BOUNDRIES =====//
        int bottomBoundry;
        int topBoundry;

        //===== GETTERS AND SETTERS =====//
        public string PlayerName { get => playerName; set => playerName = value; }
        public int PlayerScore { get => playerScore; set => playerScore = value; }
        public int PlayerWins { get => playerWins; set => playerWins = value; }
        public int PlayerBounceLvl { get => playerBounceLvl; set => playerBounceLvl = value; }
        public int PlayerSpeed { get => playerSpeed; set => playerSpeed = value; }

        //===== CONSTRUCTOR =====//
        public Player(Size playerSize, Color playerColor, Point playerLocation, int playerSpeed, int playerBounceLvl,string playerName, int windowHeight, int windowWidth)
        {
            this.Size = playerSize;
            this.BackColor = playerColor;
            this.Location = playerLocation;
            this.playerBounceLvl = playerBounceLvl;
            this.playerName = playerName;
            this.playerSpeed = playerSpeed;
            this.bottomBoundry = windowHeight - 140;
            this.topBoundry = 30;
        }

        //===== MOVE PLAYER UP =====//
        public void moveUp()
        {
            if (this.Top > topBoundry)
            { this.Top -= PlayerSpeed; }
        }

        //===== MOVE PLAYER DOWN =====//
        public void moveDown()
        {
            if (this.Top < bottomBoundry)
            { this.Top += PlayerSpeed; }
        }
    }
}
// =========================== END OF FILE =========================== //
