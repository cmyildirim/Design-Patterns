using System;

namespace Design_Patterns.StrategyPattern
{
    public class StrategyPattern : IPatternImplementation
    {
        public void Run()
        {
            Hero legendaryHero = new Snake();
            legendaryHero.SetMoveStrategy(new StandAlgorithm());
            legendaryHero.Move();
            legendaryHero.SetMoveStrategy(new CrouchAlgorithm());
            legendaryHero.Move();
            legendaryHero.SetMoveStrategy(new ProneAlgorithm());
            legendaryHero.Move();
        }
    }
}