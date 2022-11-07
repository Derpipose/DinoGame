using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinoGame
{
    public class Player{ 

        //foot body head
        private char[] stand = { 'L', '#', '@' };
        private char[] walking = { '|', '#', '@', 'L' };

        private bool playerStanding = false;
        private bool playerJumping = false;
        private bool playerDucking = false;
        private int playerJump = 0;
        public bool PlayerStanding { get { return playerStanding; } }
        public Location playerLocation = new Location();

        public Player()
        {
            playerLocation.x.Add(2);
            playerLocation.y.Add(2);

            playerLocation.x.Add(2);
            playerLocation.y.Add(3);

            playerLocation.x.Add(2);
            playerLocation.y.Add(4);

            playerLocation.x.Add(3);
            playerLocation.y.Add(2);
        }

        public void MoveForward(int status)
        {
            if(status >= 0 && playerLocation.x.Count == 2)
            {
                playerLocation.x.Add(2);
                playerLocation.y.Add(4);
            }
            if (status > 0)
            {
                //ducking
                if (status == 2)
                {
                    playerStanding = true;

                    if (playerLocation.x.Count == 4)
                    {
                        playerLocation.x.RemoveAt(3);
                        playerLocation.y.RemoveAt(3);
                    }
                    playerLocation.x.RemoveAt(2);
                    playerLocation.y.RemoveAt(2);

                }
                playerDucking = true;
                playerJump = status;


            }
            else if (status < 0)
            {
                //jumping
                if(status == -4 )
                {
                    playerStanding = true;
                    
                    playerLocation.y[0]=playerLocation.y[0]+1;
                    playerLocation.y[1] = playerLocation.y[1] + 1;
                    playerLocation.y[2] = playerLocation.y[2] + 1;
                    if(playerLocation.x.Count == 4)
                    {
                        playerLocation.x.RemoveAt(3);
                        playerLocation.y.RemoveAt(3);
                    }


                }
                else if(status == -3)
                {

                    playerLocation.y[0] = playerLocation.y[0] + 1;
                    playerLocation.y[1] = playerLocation.y[1] + 1;
                    playerLocation.y[2] = playerLocation.y[2] + 1;
                    
                }
                else if (status == -2)
                {
                    playerLocation.y[0] = playerLocation.y[0] - 1;
                    playerLocation.y[1] = playerLocation.y[1] - 1;
                    playerLocation.y[2] = playerLocation.y[2] - 1;

                }
                else if (status == -1)
                {
                    playerLocation.y[0] = playerLocation.y[0] - 1;
                    playerLocation.y[1] = playerLocation.y[1] - 1;
                    playerLocation.y[2] = playerLocation.y[2] - 1;

                }

                playerJumping = true;
                playerJump = status;

            }
            else if(status == 0)
            {
                playerJump = status;
                playerJumping = false;
                playerDucking = false; 
                
                if (playerStanding == true)
                {
                    playerStanding = false;
                    playerLocation.x.Add(3);
                    playerLocation.y.Add(2);

                }
                else
                {
                    playerStanding = true;

                    playerLocation.x.RemoveAt(3);
                    playerLocation.y.RemoveAt(3);

                }
            }

        }

        public void Print(char[,] board)
        {
            if (playerDucking == true)
            {   
                board[playerLocation.x[0], playerLocation.y[0]] = stand[0];
                board[playerLocation.x[1], playerLocation.y[1]] = stand[2];
                return;
            }
            else if (playerStanding == true)
            {
                board[playerLocation.x[0], playerLocation.y[0]] = stand[0];
                board[playerLocation.x[1], playerLocation.y[1]] = stand[1];
                board[playerLocation.x[2], playerLocation.y[2]] = stand[2];

            }
            else
            {
                board[playerLocation.x[0], playerLocation.y[0]] = walking[0];
                board[playerLocation.x[1], playerLocation.y[1]] = walking[1];
                board[playerLocation.x[2], playerLocation.y[2]] = walking[2]; 
                board[playerLocation.x[3], playerLocation.y[3]] = walking[3];

            }
        }
    }
}
