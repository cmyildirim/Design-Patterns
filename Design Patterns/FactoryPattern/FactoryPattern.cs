using System;

namespace Design_Patterns.FactoryPattern
{
    /// <summary>
    /// MainApp startup class for Real-World 
    /// Factory Method Design Pattern.
    /// </summary>
    public class FactoryPattern : IPatternImplementation
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        public void Run()
        {
            // Note: constructors call Factory Method
            Dokuman[] documents = new Dokuman[2];

            documents[0] = new Resume();
            documents[1] = new Report();

            // Display document pages
            foreach (Dokuman dokuman in documents)
            {
                Console.WriteLine("\n" + dokuman.GetType().Name + "--");
                foreach (Page page in dokuman.Pages)
                {
                    Console.WriteLine(" " + page.GetType().Name);
                }
            }
        }
    }

    
}
