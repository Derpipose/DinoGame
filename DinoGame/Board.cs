using System.ComponentModel;
using System.Globalization;
using System.Numerics;
using System.Runtime.Versioning;
using System.Security.Cryptography.X509Certificates;

namespace DinoGame
{
    public class Board
    {
        private static int boardHeight = 7;
        internal static int boardWidth = 10;
        public char[,] board = new char[boardWidth, boardHeight];
        //private Movers movers[];
        private List<IMovers> moverList = new List<IMovers>();
        private bool gameRunning = true;
        public Player Runner;
        public int frame = 0;

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

        public void NextFrame()
        {
            List<IMovers> temp = new List<IMovers>();   
            Random random = new Random();
            int freq = 30;
            int heightOfBird =   Convert.ToInt32(random.Next(0,50));;
            if( random.Next(0,freq) == 5)
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


            Runner.MoveForwad();
            foreach (IMovers m in moverList)
            {
                m.MovesForward();
                if(m.getLocation() > 0)
                {
                    temp.Add(m);
                }
                
                
            }
            moverList = temp;
            moverList.Add(new Ground(boardWidth - 1));
        }
        public void Killed(bool gameRunning)
        {

        }
        /*public Movers NewEnemy()
        {
            return movers;
        }*/
        public string Print(char[,] board)
        {
            board = new char[boardWidth, boardHeight];

            Runner.print(board);
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