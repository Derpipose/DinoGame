using System.ComponentModel;
using System.Globalization;
using System.Numerics;
using System.Runtime.Versioning;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Windows;

namespace DinoGame
{
    public class Board
    {
        private static int boardHeight = 7;
        internal static int boardWidth = 10;
        public char[,] board = new char[boardWidth, boardHeight];
        private List<IMovers> moverList = new List<IMovers>();
        private bool gameRunning = true;
        public bool GameRunning { get { return gameRunning; } }
        public Player Runner;
        public int frame = 0;
        internal int status=0;

        public class KeyEventArgs : EventArgs { }

        public Board()
        {
            Runner = new Player();
            for (int i = 0; i < boardWidth; i++)
            {
                moverList.Add(new Ground(i));
                frame++;
            }

        }
        public IMovers Mover(int moveIndex)
        { 
           IMovers indexed = moverList[moveIndex]; 
           return indexed;
        }


        public void getInput()
        {

            void Canvas_KeyDown(object sender, KeyEventArgs e)
            {
                if (e.KeyCode == Key.Down)
                {
                    status = 4; 
                }
                else if (e.Key == Key.Up)
                {
                    status = -4; 
                }
            }
        }

        public void NextFrame()
        {
            List<IMovers> temp = new List<IMovers>();   
            Random random = new Random();
            int freq = 30;
            int heightOfBird =   Convert.ToInt32(random.Next(0,50));;


            Runner.MoveForward(status);
            if(status > 0)
            {
                status++;
            }
            else if(status < 0)
            {
                status--;
            }
            foreach (IMovers m in moverList)
            {
                m.MovesForward();
                if (m.getLocation() > 0)
                {
                    temp.Add(m);
                }


            }
            moverList = temp;
            moverList.Add(new Ground(boardWidth - 1));

            if ( random.Next(0,freq) == 5)
            {
                moverList.Add(new CactusShort());
            }
            if(random.Next(0,freq) == 10)
            {
                moverList.Add(new CactusTall());
            }
            if(random.Next(0,freq) == 20)
            {
                
                moverList.Add(new SlowBird(heightOfBird));
            }
            if (random.Next(0, freq) == 20)
            {
                moverList.Add(new FastBird(heightOfBird));
            }


            
        }
        public void Killed()
        {
            //Needs work

            foreach (int y in Runner.playerLocation.y)
            {
                foreach (IMovers m in moverList)
                {
                    if (m.getLocation() == y && m.getHeight() == Runner.playerLocation.x[1])
                    {
                        gameRunning = false;
                    }

                }
            }



        }
        
        public string Print(char[,] board)
        {
            board = new char[boardWidth, boardHeight];

            Runner.Print(board);
            foreach (IMovers m in moverList)
            {
                m.print(board);
            }

            string boardPrint = "";
            for (int j = boardHeight-1; j > 0; j--)
            {
                for (int i = 0; i < boardWidth; i++)
                {
                    if (board[i, j] == '\u0000')
                    {
                        boardPrint += " ";
                    }
                    else
                    {
                        boardPrint += board[i, j];
                    }
                }
                boardPrint += "\n";
            }

            return boardPrint;
        }

    }

}