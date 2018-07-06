using System;

namespace Design_Patterns.StrategyPattern
{
    public abstract class Hero
    {
        public IMoveAlgorithm MoveStrategy { get; set; }

        public void SetMoveStrategy(IMoveAlgorithm strategy)
        {
            var oldStrategy = MoveStrategy == null ? "Nothing" : MoveStrategy.GetType().Name;
            var newStrategy = strategy == null ? "Nothing" : strategy.GetType().Name;
            Console.WriteLine("Switching move strategy from {0} to {1}", oldStrategy, newStrategy);
            MoveStrategy = strategy;
        }

        public void Move()
        {
            Console.Write("Go: ");
            MoveStrategy.Go();
        }
    }
}