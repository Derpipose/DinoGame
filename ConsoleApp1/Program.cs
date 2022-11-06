// See https://aka.ms/new-console-template for more information
using DinoGame;


Board game = new Board();



do
{
    Thread.Sleep(500);
    Console.Clear();

    Console.Write(game.Print(game.board));
    game.NextFrame();
    game.Killed();
    game.getInput();




} while (game.GameRunning);

