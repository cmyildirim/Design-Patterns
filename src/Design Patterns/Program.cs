using System;
using static System.Console;

namespace Design_Patterns
{
    public class Program
    {
        public static void Main(string[] args)
        {
            RunAndPrintStrategy(typeof(StrategyPattern.StrategyPattern));
            RunAndPrintStrategy(typeof(DecoratorPattern.DecoratorPattern));
            RunAndPrintStrategy(typeof(FactoryPattern.FactoryPattern));
            RunAndPrintStrategy(typeof(ObserverPattern.ObserverPattern));
            RunAndPrintStrategy(typeof(ChainOfResponsibilityPattern.ChainOfResponsibilityPattern));
        }

        private static void RunAndPrintStrategy(Type patternImplementationType)
        {
            try
            {
                var patternImplementation = (IPatternImplementation) Activator.CreateInstance(patternImplementationType);
                WriteLine("****" + patternImplementation.GetType().Name + "****");
                patternImplementation.Run();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n!!!ERROR!!! in implementation!");
                Console.WriteLine(ex.Message + "\n");
                Console.ResetColor();
            }
            
            PrintSeparator();
        }

        private static void PrintSeparator()
        {
            WriteLine("***********************************************************");
        }
    }
}
