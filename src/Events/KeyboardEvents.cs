using PongGame.src.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PongGame.src.Events
{
    internal class KeyboardEvents
    {
        //===== VARIABLES =====//
        bool wPressed = false;
        bool sPressed = false;
        bool iPressed = false;
        bool kPressed = false;

        //===== CALLED WHEN A KEY IS PRESSED OR RELEASED =====//
        public void keyInput(KeyEventArgs e, string type)
        {
            if (e.KeyCode == Keys.W) 
            {
                if (type == "down")
                {wPressed = true;}
                else { wPressed = false; }
            }

            if (e.KeyCode == Keys.S)
            {
                if (type == "down")
                { sPressed = true; }
                else { sPressed = false; }
            }

            if (e.KeyCode == Keys.I)
            {
                if (type == "down")
                { iPressed = true; }
                else { iPressed = false; }
            }

            if (e.KeyCode == Keys.K)
            {
                if (type == "down")
                { kPressed = true; }
                else { kPressed = false; }
            }
        }

        //===== OUTPUT FOR PLAYER MOVEMENT =====//
        public void playerOutput(Player player1, Player player2)
        {
            if (wPressed)
            { player1.moveUp(); }

            if (sPressed)
            { player1.moveDown(); }

            if (iPressed)
            { player2.moveUp(); }

            if (kPressed)
            { player2.moveDown(); }
        }
    }
}
// =========================== END OF FILE =========================== //
