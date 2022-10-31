using DinoGame;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    
    public class Feature1StepDefinitions
    {

        public Feature1StepDefinitions(ScenarioContext scenarC)
        {
            _sc = scenarC;
            Board board = new Board();
            _sc.Add("game", board);
        }
        private ScenarioContext _sc;


        [Given(@"One unit of game time")]
        public void GivenOneUnitOfGameTime()
        {
            throw new PendingStepException();
        }

        [When(@"When time increments")]
        public void WhenWhenTimeIncrements()
        {
            Board game = _sc.Get<Board>("game");
            game.Next();
            _sc.Set<Board>(game, "gmae");
        }

        [Then(@"the man steps")]
        public void ThenTheManSteps()
        {
            Board game = _sc.Get<Board>("game");
            char check = game.Get(3,2);
            check = '\u0192';
        }

        [Then(@"the man stands")]
        public void ThenTheManStands()
        {
            Board game = _sc.Get<Board>("game");
            char check = game.Get(3,2);
            check = '\u0032';
        }

    }
}
