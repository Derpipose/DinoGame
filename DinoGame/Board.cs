﻿using System.ComponentModel;
using System.Globalization;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace DinoGame
{
    public class Board
    {
        private static int boardHeight = 7;
        private static int boardWidth = 10;
        public char[,] board = new char[boardWidth, boardHeight];
        //private Movers movers[];
        private List<IMovers> moverList = new List<IMovers>();
        private bool gameRunning = true;
        public Player Runner;

        public Board()
        {
            Runner = new Player();
            for (int i = 0; i < boardWidth; i++) {
                moverList.Add( new Ground());    
            }
        }
        public IMovers Mover(int moveIndex)
        { 
           IMovers indexed = moverList[moveIndex]; 
           return indexed;
        }

        public void NextFrame()
        {
            Runner.MoveForwad();
            foreach (IMovers m in moverList)
            {
                m.MovesForward();
            }
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
            string boardPrint = "";
            for (int j = 0; j < boardHeight; j++)
            {
                for (int i = 0; i < boardWidth; i++)
                {
                    boardPrint += board[i, j];
                }
                boardPrint += "\n";
            }

            return boardPrint;
        }

    }

}