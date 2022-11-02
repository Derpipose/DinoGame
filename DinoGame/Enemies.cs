using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinoGame
{
    internal class Enemies: Movers
    {
        //public Dictionary<> location {get;}
        private char[] graphic = { '\u0068' };
        public char[] Graphic { get; }
        public void MovesForward()
        {

        }
    }

    internal class Cactus :Enemies, Movers
    {
        //public Dictionary<> location {get;}
        private char[] graphic = { '\u0237' };
        public char[] Graphic { get; }
        public void MovesForward()
        {

        }
    }

    internal class CactusShort :Cactus, Movers
    {
        //public Dictionary<> location {get;}
        private char[] graphic = { '\u0241' };
        public char[] Graphic { get; }
        public void MovesForward()
        {

        }
    }

    internal class CactusTall : Cactus, Movers
    {
        //public Dictionary<> location {get;}
        private char[] graphic = { '\u0240', '\u0241' };
        public char[] Graphic { get; }
        public void MovesForward()
        {

        }
    }

    internal class Bird :Enemies, Movers
    {
        //public Dictionary<> location {get;}
        private char[] graphic = { '\u0170' };
        public char[] Graphic { get; }
        public void MovesForward()
        {

        }
    }

    internal class Ground : Movers
    {
        //public Dictionary<> location {get;}
        private char[] graphic = { '\u0178' };
        public char[] Graphic { get; }
        public void MovesForward()
        {

        }
    }

    internal class GroundAlt1:Ground, Movers
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

    }

}
