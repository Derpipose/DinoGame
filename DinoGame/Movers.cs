using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinoGame
{
    public interface IMovers
    {
        public char[] Graphic { get; }
        public void MovesForward();
        public void print(char[,] board);
    }

    internal class Cactus : IMovers
    {
        
        private char[] graphic = { '\u0237' };
        public char[] Graphic { get { return null; } }
        public void MovesForward()
        {

        }
        public void print(char[,] board)
        {

        }
    }

    internal class CactusShort :Cactus, IMovers
    {
        public CactusShort()
        {
            x = Board.boardWidth - 1;
        }
        public int x;
        public int y = 2;
        //public Dictionary<> location {get;}
        private char[] graphic = { '\u0241' };
        public char[] Graphic { get; }
        public void MovesForward()
        {
            x -= 1;
            if (x < 0)
            {
                x = Board.boardWidth - 1;
            }
        }
        public void print(char[,] board)
        {
            board[x, y] = graphic[0];
        }
    }

    internal class CactusTall : Cactus, IMovers
    {
        //public Dictionary<> location {get;}
        private char[] graphic = { '\u0240', '\u0241' };
        public char[] Graphic { get; }
        public void MovesForward()
        {
            


        }
        public void print(char[,] board)
        {

        }
    }

    internal class Bird : IMovers
    {
        //public Dictionary<> location {get;}
        private char[] graphic = { '\u0170' };
        public char[] Graphic { get; }
        public void MovesForward()
        {

        }
        public void print(char[,] board)
        {

        }
    }

    internal class Ground : IMovers
    {
        public int x;
        public int y=1;
        public int type;
        public Ground(int input)
        {
            x = input;
            type = input % 3;
        }
        //public Dictionary<> location {get;}
        public char[] graphic = {  '\u0176', '\u0178', '\u0177'  };
        public char[] Graphic { get; }
        public void MovesForward()
        {
            x -= 1;
            if (x < 0)
            {
                x = Board.boardWidth-1;
            }
        }
        public void print(char[,] board)
        {
            board[x,y] = graphic[type];
        }
    }

    /*internal class GroundAlt1:Ground, Movers
    {
        //public Dictionary<> location {get;}
        private char[] graphic = { '\u0177' };
        public char[] Graphic { get; }
    }

    internal class GroundAlt2 : Ground, Movers
    {
        //public Dictionary<> location {get;}
        private char[] graphic = { '\u0176' };
        public char[] Graphic { get; }

    }*/

}