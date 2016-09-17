namespace Design_Patterns.StrategyPattern
{
    public abstract class Hero
    {
        private IMoveAlgorithm _moveStrategy;

        protected Hero()
        { }

        public void SetMoveStrategy(IMoveAlgorithm strategy)
        {
            _moveStrategy = strategy;
        }

        public void Move()
        {
            _moveStrategy.Go();
        }
    }
}