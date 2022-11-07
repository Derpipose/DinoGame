// See https://aka.ms/new-console-template for more information
using DinoGame;


Board game = new Board();



do
{
    Thread.Sleep(100);
    Console.Clear();

    Console.Write(game.Print(game.board));
    game.getInput();
    game.NextFrame();
    game.Killed();




} while (game.GameRunning);

