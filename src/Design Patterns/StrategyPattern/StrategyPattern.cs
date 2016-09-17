using System.Runtime.CompilerServices;

namespace Design_Patterns.StrategyPattern
{
    public class StrategyPattern : IPatternImplementation
    {
        public void Run()
        {
            Hero legendaryHero = new Snake();
            legendaryHero.SetMoveStrategy(new Standing());
            legendaryHero.Move();
            legendaryHero.SetMoveStrategy(new Crouching());
            legendaryHero.Move();
            legendaryHero.SetMoveStrategy(new Prone());
            legendaryHero.Move();
        }
    }
}