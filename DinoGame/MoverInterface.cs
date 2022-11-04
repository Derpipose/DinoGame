using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinoGame
{
    internal interface Mover
    {
        static Board screen = new Board();
        int x { get; set; }
        int y { get; set; }
        char image { get; set; }
        public void MoveForward()
        {

            screen.board[x, y] = '\u0032';
            screen.board[x-=1,y] = image;
        }
        public bool HitPlayerCheck()
        {
            if(screen.board[x - 1, y] == '\u0202' || screen.board[x - 1, y] == '\u0225' || screen.board[x - 1, y] == '\u0149' || screen.board[x - 1, y] == '\u0192' )
            {
                return true;
            }
            else return false;  
        }

        public void print();
    }
}
