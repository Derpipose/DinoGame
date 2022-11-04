using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinoGame
{
    public class Player{ 

        //foot body head
        private char[] stand = { '\u0126', '\u0065', '\u0064' };
        private char[] walking = { '\u0217', '\u0225', '\u0149', '\u0062' };
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

        public void print(char[,] board)
        {
            if (playerStanding == true)
            {
                board[2, 2] = stand[0];
                board[2, 3] = stand[1];
                board[2, 4] = stand[2];

            }
            else
            {
                board[2, 2] = walking[0];
                board[2, 3] = walking[1];
                board[2, 4] = walking[2];
                board[3, 2] = walking[3];


            }
        }
    }
}
