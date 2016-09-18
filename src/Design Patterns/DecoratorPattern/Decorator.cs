namespace Design_Patterns.DecoratorPattern
{
    /// <summary>
    /// The 'Decorator' abstract class
    /// </summary>
    abstract class Decorator : LibraryItem
    {
        protected LibraryItem LibraryItem;

        protected Decorator(LibraryItem libraryItem)
        {
            LibraryItem = libraryItem;
        }

        public override void Display()
        {
            LibraryItem.Display();
        }
    }
}