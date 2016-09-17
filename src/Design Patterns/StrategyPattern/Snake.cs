using System;

namespace Design_Patterns.StrategyPattern
{
    internal class Snake : Hero
    {
        public Snake()
        {
            Console.WriteLine("Snake: Kept you waiting, huh?");
        }
    }
}