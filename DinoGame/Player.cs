using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinoGame
{
    public class Player
    {
        private char[] stand = { '\u0202', '\u0225', '\u0149' };
        private char[] walk = { '\u0217', '\u0225', '\u0149', '\u0192' };
        private bool playerStanding = false;
        public bool PlayerStanding { get { return playerStanding; } }

        public void MoveForwad()
        {
            if (playerStanding == true)
            {
                playerStanding = false;

            }
            else
            {
                playerStanding = true;

            }

        }
    }
}
