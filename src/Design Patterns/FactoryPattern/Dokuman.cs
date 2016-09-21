using System.Collections.Generic;

namespace Design_Patterns.FactoryPattern
{
    /// <summary>
    /// The 'Creator' abstract class
    /// </summary>
    abstract class Dokuman
    {
        private List<Page> _pages = new List<Page>();

        // Constructor calls abstract Factory method
        public Dokuman()
        {
            this.CreatePages();
        }

        public List<Page> Pages
        {
            get { return _pages; }
        }

        // Factory Method
        public abstract void CreatePages();
    }
}
