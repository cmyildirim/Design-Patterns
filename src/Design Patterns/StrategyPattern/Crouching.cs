using System;

namespace Design_Patterns.StrategyPattern
{
    public class Crouching : IMoveAlgorithm
    {
        public void Go()
        {
            Console.WriteLine("Crouching Go: Moving slowly");
        }
    }
}