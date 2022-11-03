// See https://aka.ms/new-console-template for more information
using DinoGame;


Board game = new Board();
bool gameRunning = true;


do
{
    Console.Clear();
    Thread.Sleep(500);

    Console.Write(game.Print(game.board));
    

} while (gameRunning);

