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
    }

    internal class Cactus : IMovers
    {
        
        private char[] graphic = { '\u0237' };
        public char[] Graphic { get { return null; } }
        public void MovesForward()
        {

        }
    }

    internal class CactusShort :Cactus, IMovers
    {
        //public Dictionary<> location {get;}
        private char[] graphic = { '\u0241' };
        public char[] Graphic { get; }
        public void MovesForward()
        {

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
    }

    internal class Bird : IMovers
    {
        //public Dictionary<> location {get;}
        private char[] graphic = { '\u0170' };
        public char[] Graphic { get; }
        public void MovesForward()
        {

        }
    }

    internal class Ground : IMovers
    {
        public int x;
        public int y;
        public Ground()
        {
        }
        //public Dictionary<> location {get;}
        public char[] graphic = {  '\u0176', '\u0178', '\u0177'  };
        public char[] Graphic { get; }
        public void MovesForward()
        {

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