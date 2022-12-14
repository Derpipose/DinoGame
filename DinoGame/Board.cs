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
        int score = 0;
        private static int boardHeight = 7;
        internal static int boardWidth = 61;
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

            
            while (Console.KeyAvailable)
            {
                var ch = Console.ReadKey(false).Key;
                switch (ch)
                {
                    case ConsoleKey.Escape:
                        Console.WriteLine("\n  Game is now ended (escape key pressed).");
                        Escape();
                        return;
                    case ConsoleKey.UpArrow:
                        if (status == 0)
                        {
                        status = -4;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if(status == 0)
                        {
                        status = 2;

                        }
                        break;
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
            if(status < 0)
            {
                //duck
                status+=1;
            }
            else if(status > 0)
            {
                //jump
                status-=1;
            }
            foreach (IMovers m in moverList)
            {
                m.MovesForward();
                if (m.getLocation() > 0)
                {
                    temp.Add(m);
                }
                else
                {
                    score += m.getScore();
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
            
            foreach (IMovers m in moverList)
            {
                for(int i = 0; i < Runner.playerLocation.x.Count; i++)
                {
                    if (m.getHeight() == Runner.playerLocation.y[i] && m.getLocation() == Runner.playerLocation.x[i])
                    {
                        gameRunning = false;
                    }
                }
                    
            }
            
        }
        
        public void Escape()
        {
            gameRunning = false;
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
            Console.WriteLine($"Score:{score}");
            return boardPrint;
        }

    }

}