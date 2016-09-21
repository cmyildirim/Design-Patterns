using System;
using static System.Console;

namespace Design_Patterns
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IPatternImplementation patternImplementation = new StrategyPattern.StrategyPattern();
            RunAndPrintStrategy(patternImplementation);

            patternImplementation = new DecoratorPattern.DecoratorPattern();
            RunAndPrintStrategy(patternImplementation);

            patternImplementation = new FactoryPattern.FactoryPattern();
            RunAndPrintStrategy(patternImplementation);

            patternImplementation = new ObserverPattern.ObserverPattern();
            RunAndPrintStrategy(patternImplementation);
        }

        private static void RunAndPrintStrategy(IPatternImplementation patternImplementation)
        {
            WriteLine("****" + patternImplementation.GetType().Name + "****");
            try
            {
                patternImplementation.Run();
            }
            catch (Exception ex)
            {
                Console.WriteLine("\n!!!ERROR!!! in implementation!");
                Console.WriteLine(ex.Message + "\n");
            }
            
            PrintSeparator();
        }

        private static void PrintSeparator()
        {
            WriteLine("***********************************************************");
        }
    }
}
