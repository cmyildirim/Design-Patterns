using System;

namespace Design_Patterns.StrategyPattern
{
    public class ProneAlgorithm : IMoveAlgorithm
    {
        public void Go()
        {
            Console.WriteLine("Prone Go: Moving very slowly but silently");
        }
    }
}