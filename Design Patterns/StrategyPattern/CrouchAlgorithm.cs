using System;

namespace Design_Patterns.StrategyPattern
{
    public class CrouchAlgorithm : IMoveAlgorithm
    {
        public void Go()
        {
            Console.WriteLine("Moving slowly");
        }
    }
}