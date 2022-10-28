// See https://aka.ms/new-console-template for more information
using DinoGame;

Thread.Sleep(50);
Board game = new Board();
for(int i = 0; i < 7; i++)
{
    for(int j = 0; j < 10; j++)
    {
        Console.Write(game.board[i, j]);
    }
    Console.Write("\n");
}