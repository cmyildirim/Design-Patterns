using System;

namespace Design_Patterns.DecoratorPattern
{
    /// <summary>
    /// The 'ConcreteComponent' class
    /// </summary>
    class Book : LibraryItem
    {
        private readonly string _author;
        private readonly string _title;

        public Book(string author, string title, int numCopies)
        {
            _author = author;
            _title = title;
            NumCopies = numCopies;
        }

        public override void Display()
        {
            Console.WriteLine("\nBook ------ ");
            Console.WriteLine(" Author: {0}", _author);
            Console.WriteLine(" Title: {0}", _title);
            Console.WriteLine(" # Copies: {0}", NumCopies);
        }
    }
}