﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IPatternImplementation patternImplementation = new StrategyPattern.StrategyPattern();
            patternImplementation.Run();
        }
    }

    public interface IPatternImplementation
    {
        void Run();
    }
}
