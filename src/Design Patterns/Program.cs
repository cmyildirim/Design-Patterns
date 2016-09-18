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
        }

        private static void RunAndPrintStrategy(IPatternImplementation patternImplementation)
        {
            WriteLine("****" + patternImplementation.GetType().Name + "****");
            patternImplementation.Run();
            PrintSeparator();
        }

        private static void PrintSeparator()
        {
            WriteLine("***********************************************************");
        }
    }
}
