using System;

namespace Design_Patterns.DecoratorPattern
{
    /// <summary>
    /// The 'ConcreteComponent' class
    /// </summary>
    public class Video : LibraryItem
    {
        private readonly string _director;
        private readonly string _title;
        private readonly int _playTime;

        public Video(string director, string title, int playTime, int numCopies)
        {
            _director = director;
            _title = title;
            _playTime = playTime;
            NumCopies = numCopies;
        }

        public override void Display()
        {
            Console.WriteLine("\nVideo ----- ");
            Console.WriteLine(" Director: {0}", _director);
            Console.WriteLine(" Title: {0}", _title);
            Console.WriteLine(" # Copies: {0}", NumCopies);
            Console.WriteLine(" Playtime: {0}\n", _playTime);
        }
    }
}
