using DinoGame;
using NUnit.Framework;
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
            game.NextFrame();
            _sc.Set<Board>(game, "game");
        }

        [Then(@"the man steps")]
        public void ThenTheManSteps()
        {
            Board game = _sc.Get<Board>("game");
            game.Runner.PlayerStanding.Should().BeTrue();

        }

        [Then(@"the man stands")]
        public void ThenTheManStands()
        {
            Board game = _sc.Get<Board>("game");
            game.Runner.PlayerStanding.Should().BeFalse();

        }
        [Then(@"cactus moves forward (.*) cell")]
        public void ThenCactusMovesForwardCell(int p0)
        {
            throw new PendingStepException();
        }

        [Given(@"cactus at (.*)")]
        public void GivenCactusAt(Decimal p0)
        {
            throw new PendingStepException();
        }

        [Then(@"the dino is hit and dies")]
        public void ThenTheDinoIsHitAndDies()
        {
            throw new PendingStepException();
        }


    }
}
