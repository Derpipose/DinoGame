using System.ComponentModel;
using System.Globalization;
using System.Numerics;
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

        public Board()
        {
            Runner = new Player();
            
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
            if( random.Next(0,50) == 5)
            {
                moverList.Add(new CactusShort());
            }
            if(random.Next(0,50) == 5)
            {
                moverList.Add(new CactusTall());
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