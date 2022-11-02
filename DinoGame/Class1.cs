﻿using System.ComponentModel;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace DinoGame
{
    public class DinoClass
    {
        
    }
    public class Board1
    {
        private static int boardHeight = 7;
        private static int boardWidth = 10;
        public char[,] board = new char[boardWidth, boardHeight];
        //private Movers movers[];
        private List<Movers> moverList = new List<Movers>();
        private bool gameRunning = true;
        DinoRunner runner;
        public Board1(){
            runner = new DinoRunner();
            for (int i = 0; i < boardWidth; i++) {
                moverList.Add( new Ground(1, i));    
            }
        }
        public Movers Mover(int moveIndex)
        { 
           Movers indexed = moverList[moveIndex]; 
           return indexed;
        }

        public void NextFrame(Movers movers)
        {
            foreach (Movers m in moverList)
            {
                m.MovesForward();
            }
        }
        public void Killed(bool gameRunning)
        {

        }
/*        public Movers NewEnemy()
        {
            return movers;
        }*/
        public string Print(char[,] board)
        {
            string boardRow = "";
            for (int j = 0; j < boardHeight; j++) {
                for (int i = 0; i < boardWidth; i++)
                {
                    boardRow += board[i, j];
                }
                boardRow += "\n";
            }
            
            return boardRow;
        }

    }

    public interface Movers
    {
        //public Dictionary<> location {get;}
        public char[] Graphic { get; }
        public void MovesForward();
    }



    public class Board
    {
        DinoRunner texture = new DinoRunner();
        int j = 0;
        bool gameRunning = true;
        public char[,] board = new char[10, 7];
        //public char[] runner = new char[2] { texture.Dino1[0], texture.Dino2[0] };   

        public bool LegsTogether;

        public char Get(int x, int y )
        {
            char cell = board[x, y];
            return cell;
        }
        public void Next()
        {
           // do
           // {
                for(int i = 0; i < 10; i++)
                {
                    board[i, 1] = texture.Ground[(i+j)%3];
                    if(i%2 == 0)
                    {
                        board[2, 2] = texture.Dino1[0];
                        board[2, 3] = texture.Dino1[1];
                        board[2, 4] = texture.Dino1[2];
                        board[3, 2] = '\u0032';
                        LegsTogether = true;
                    }
                    else
                    {
                        board[2, 2] = texture.Dino2[0];
                        board[3, 2] = texture.Dino2[3];
                        board[2, 3] = texture.Dino2[1];
                        board[2, 4] = texture.Dino2[2];
                        LegsTogether = false;
                    }
                }
                j++;

            //} while (gameRunning);
        }

    }

    public class DinoRunner
    {
        public char[] Ground = {'\u0176', '\u0178', '\u0177'};
        public char[] Dino1 = { '\u0202', '\u0225', '\u0149' };
        public char[] Dino2 = { '\u0217', '\u0225', '\u0149', '\u0192'};
        public char[] Cactus1 = { '\u0241' };
        public char[] Cactus2 = { '\u0240', '\u0241' };
        public char[] Bird = { '\u0174', '\u0170' };

    }
}