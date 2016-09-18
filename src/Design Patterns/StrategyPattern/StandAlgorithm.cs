using System;

namespace Design_Patterns.StrategyPattern
{
    public class StandAlgorithm : IMoveAlgorithm
    {
        public void Go()
        {
            Console.WriteLine("Running");
        }
    }
}