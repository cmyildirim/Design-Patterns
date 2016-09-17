using System;

namespace Design_Patterns.StrategyPattern
{
    public class Standing : IMoveAlgorithm
    {
        public void Go()
        {
            Console.WriteLine("Standing Go: Running");
        }
    }
}