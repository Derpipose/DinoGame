using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DinoGame
{
    public interface IMovers
    {
        public char[] Graphic { get; }
        public void MovesForward();
        public void print(char[,] board);
        public int getLocation();
        public int getHeight();
        public bool HitPlayer();
        public int getScore();
    }

    internal class Cactus : IMovers
    {
        
        private char[] graphic = { '\u0237' };
        public char[] Graphic { get { return null; } }
        public void MovesForward()
        {

        }
        public int getScore()
        {
            return 0;
        }
        public void print(char[,] board)
        {

        }
        public int getLocation() {
            return 0;
        }
        public int getHeight()
        {
            return 0;
        }

        public bool HitPlayer() {
            return false;
        }
    }

    internal class CactusShort :Cactus, IMovers
    {

        public int x;
        public int y = 2;
        bool hitPlayer;
        public CactusShort()
        {

            x = Board.boardWidth - 1;
            hitPlayer = false;
        }
        


        private char[] graphic = { '#' };
        public char[] Graphic { get; }
        public void MovesForward()
        {
            //Need to figure out how to check ahead. 
            // if (Board.board[x-1,y] != '\u0000')
            x -= 1;
        }
        public int getScore()
        {
            return 5;
        }
        public void print(char[,] board)
        {
            board[x, y] = graphic[0];
        }
        public int getLocation() {
            return x;
        }
        public int getHeight()
        {
            return y;
        }
        public bool HitPlayer()
        {
            return hitPlayer;
        }
    }

    internal class CactusTall : Cactus, IMovers
    {
        public int x;
        public int y=2;
        public CactusTall(){
            x = Board.boardWidth - 1;
        }
    //public Dictionary<> location {get;}
    private char[] graphic = { '\u0240', '\u0241' };
        public char[] Graphic { get; }
        public void MovesForward()
        {
            x -= 1;
        }
        public int getScore()
        {
            return 10;
        }
        public void print(char[,] board)
        {
            board[x, y] = graphic[0];
            board[x, y+1] = graphic[1]; 
        }
        public int getLocation()
        {
            return x;
        }
        public int getHeight()
        {
            return y;
        }
        public bool HitPlayer()
        {
            return false;
        }
    }

    internal class SlowBird : IMovers
    {
        public int x;
        public int y;

        public SlowBird(int number)
        {
            y = (number % 3) + 4;
            x = Board.boardWidth - 1;
        }
        //public Dictionary<> location {get;}
        private char[] graphic = { '\u0170' };
        public char[] Graphic { get; }
        public void MovesForward()
        {
            x -= 1;
        }
        public int getScore()
        {
            return 5;
        }
        public void print(char[,] board)
        {
            board[x, y] = graphic[0];
        }
        public int getLocation()
        {
            return x;
        }
        public int getHeight()
        {
            return y;
        }
        public bool HitPlayer()
        {
            return false;
        }
    }

    internal class FastBird : IMovers
    {
        public int x;
        public int y;

        public FastBird(int number)
        {
            y = (number % 3) + 4;
            x= Board.boardWidth - 1;    
        }
        //public Dictionary<> location {get;}
        private char[] graphic = { '\u0170' };
        public char[] Graphic { get; }
        public void MovesForward()
        {
            x -= 2;
        }
        public int getScore()
        {
            return 10;
        }
        public void print(char[,] board)
        {
            board[x, y] = graphic[0];
        }
        public int getLocation()
        {
            return x;
        }
        public int getHeight()
        {
            return y;
        }
        public bool HitPlayer()
        {
            return false;
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
            Random random = new Random();
            type = Convert.ToInt32(random.Next(0, 3));
        }
        //public Dictionary<> location {get;}
        public char[] graphic = {  '\u0176', '\u0178', '\u0177'  };
        public char[] Graphic { get; }
        public void MovesForward()
        {
            x -= 1;
            
        }
        public int getScore()
        {
            return 1;
        }
        public void print(char[,] board)
        {
            board[x,y] = graphic[type];
        }
        public int getLocation()
        {
            return x;
        }
        public int getHeight()
        {
            return y;
        }
        public bool HitPlayer()
        {
            return false;
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