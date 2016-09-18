using System;

namespace Design_Patterns.StrategyPattern
{
    public abstract class Hero
    {
        private IMoveAlgorithm _moveStrategy;

        protected Hero()
        { }

        public void SetMoveStrategy(IMoveAlgorithm strategy)
        {
            var oldStrategy = _moveStrategy == null ? "Nothing" : _moveStrategy.GetType().Name;
            var newStrategy = strategy == null ? "Nothing" : strategy.GetType().Name;
            Console.WriteLine("Switching move strategy from {0} to {1}", oldStrategy, newStrategy);
            _moveStrategy = strategy;
        }

        public void Move()
        {
            Console.Write("Go: ");
            _moveStrategy.Go();
        }
    }
}