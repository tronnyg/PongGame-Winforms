using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PongGame.src.Objects
{
    internal class pongBall: PictureBox
    {
        //===== BALL SPEED VARIABLES =====//
        int ballxSpeed = 8;
        int ballySpeed = 8;

        //===== BALL LOCATION VARIABLES =====//
        int xMidpoint;
        int yMidpoint;

        //===== WINDOW BOUNDRY VARIABLES =====//
        int bottomBoundry;
        int topBoundry;
        int leftBoundry;
        int rightBoundry;

        //===== CONSTRUCTOR =====//
        public pongBall(Size ballSize, Color ballColor, int WindowWidth, int WindowHeight)
        {
            this.Size = ballSize;
            calcBoundary(WindowWidth, WindowHeight);
            this.Location = new System.Drawing.Point(xMidpoint,yMidpoint);
            this.BackColor = ballColor;
        }

        //===== CALCULATE WINDOW MIDPOINT & BOUNDARIES =====//
        public void calcBoundary(int Width, int Height)
        {
            xMidpoint = Width / 2;
            yMidpoint = Height / 2;
            bottomBoundry = Height - 30;
            topBoundry = 0;
            leftBoundry = 0;
            rightBoundry = Width - 30;
        }

        //===== MOVE BALL =====//
        public void moveBall()
        {
            this.Top -= ballySpeed;
            this.Left -= ballxSpeed;
        }

        //===== CHECK IF BALL HAS HIT OR EXITED BOUNDRIES =====//
        public void checkBoundries()
        {
            if (ballBottomHit())
            {
                ballySpeed *= -1;
            }

            if (ballTopHit())
            {
                ballySpeed *= -1;
            }

            if (ballLeftExit())
            {
                this.Top = yMidpoint;
                this.Left = xMidpoint;
            }

            if (ballRightExit())
            {
                this.Top = yMidpoint;
                this.Left = xMidpoint;
            }
        }

        //===== CHECK IF BALL HITS BOTTOM OF WINDOW =====//
        private bool ballBottomHit()
        {
            bool hit = false;
            if (this.Top >= bottomBoundry)
            {
                hit = true;
            }
            return hit;
        }

        //===== CHECK IF BALL HITS TOP OF WINDOW =====//
        private bool ballTopHit()
        {
            bool hit = false;
            if (this.Top <= topBoundry)
            {
                hit = true;
            }
            return hit;
        }

        //===== CHECK IF BALL EXITS LEFT SIDE OF WINDOW =====//
        private bool ballLeftExit()
        {
            bool exit = false;
            if (this.Left <= leftBoundry)
            {
                exit = true;
            }
            return exit;
        }

        //===== CHECK IF BALL EXITS RIGHT SIDE OF WINDOW =====//
        private bool ballRightExit()
        {
            bool exit = false;
            if (this.Left >= rightBoundry)
            {
                exit = true;
            }
            return exit;
        }

    }
}
// =========================== END OF FILE =========================== //