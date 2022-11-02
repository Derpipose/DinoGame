// See https://aka.ms/new-console-template for more information
using DinoGame;


Board game = new Board();
bool gameRunning = true;
Board1 board = new Board1();

do
{
    Console.Clear();
    Thread.Sleep(500);
    /*for (int i = 0; i < 7; i++)
    {
        for (int j = 0; j < 10; j++)
        {
            Console.Write(game.board[i, j]);
        }
        Console.Write("\n");
    }*/
    Console.Write(board.Print(game.board));
    

} while (gameRunning);

