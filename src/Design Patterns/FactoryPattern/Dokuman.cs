using System.Collections.Generic;

namespace Design_Patterns.FactoryPattern
{
    /// <summary>
    /// The 'Creator' abstract class
    /// </summary>
    internal abstract class Dokuman
    {
        // Constructor calls abstract Factory method
        protected Dokuman()
        {
            CreatePages();
        }

        public List<Page> Pages { get; } = new List<Page>();

        // Factory Method
        public abstract void CreatePages();
    }
}
