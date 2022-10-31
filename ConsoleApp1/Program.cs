// See https://aka.ms/new-console-template for more information
using DinoGame;


Board game = new Board();
bool gameRunning = true;

do
{
    Thread.Sleep(50);
    for (int i = 0; i < 7; i++)
    {
        for (int j = 0; j < 10; j++)
        {
            Console.Write(game.board[i, j]);
        }
        Console.Write("\n");
    }

} while (gameRunning);

